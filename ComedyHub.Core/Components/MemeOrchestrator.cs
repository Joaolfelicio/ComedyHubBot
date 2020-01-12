﻿using ComedyHub.Core.Auth.Contracts;
using ComedyHub.Core.Components.Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComedyHub.Core.Components
{
    public class MemeOrchestrator : IMemeOrchestrator
    {
        private readonly IMemeProcessor _memeProcessor;
        private readonly IPublishComponent _publishComponent;
        private readonly INotificationComponent _notificationComponent;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ITwitterAuth TwitterAuth { get; }

        public MemeOrchestrator(IMemeProcessor memeProcessor,
                                IPublishComponent publishComponent,
                                INotificationComponent notificationComponent)
        {
            _memeProcessor = memeProcessor;
            _publishComponent = publishComponent;
            _notificationComponent = notificationComponent;
        }

        public async Task Process()
        {
            try
            {
                var meme = await _memeProcessor.ProcessMeme();

                var publishedObj = _publishComponent.PublishMeme(meme);

                await _notificationComponent.SendSucessfulNotification(publishedObj);

            }
            catch (Exception exception)
            {
                logger.Error(exception);

                await _notificationComponent.SendFailureNotification(exception);

                throw;
            }
        }
    }
}
