﻿using Wirehome.Core.Cloud.Messages;

namespace Wirehome.Core.Cloud
{
    public class ConnectorChannelReceiveResult
    {
        public ConnectorChannelReceiveResult(CloudMessage message, bool closeConnection)
        {
            Message = message;
            CloseConnection = closeConnection;
        }

        public CloudMessage Message { get; }

        public bool CloseConnection { get; }
    }
}
