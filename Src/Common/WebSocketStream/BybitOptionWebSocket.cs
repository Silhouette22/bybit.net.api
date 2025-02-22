﻿using bybit.net.api.Websockets;
using System.Net.WebSockets;

namespace bybit.net.api.WebSocketStream
{
    public class BybitOptionWebSocket : BybitWebSocket
    {
        public BybitOptionWebSocket(bool useTestNet = false, int pingIntevral = 20, int receiveBufferSize = 8192, string? apiKey = null, string? apiSecret = null)
            : base(new BybitWebSocketHandler(new ClientWebSocket()), GetStreamUrl(useTestNet), pingIntevral, receiveBufferSize, apiKey, apiSecret)
        {
        }

        public BybitOptionWebSocket(IBybitWebSocketHandler handler, bool useTestNet = false, int pingIntevral = 20, int receiveBufferSize = 8192, string? apiKey = null, string? apiSecret = null)
            : base(handler, GetStreamUrl(useTestNet), pingIntevral, receiveBufferSize, apiKey, apiSecret)
        {
        }

        private static string GetStreamUrl(bool useTestNet)
        {
            return !useTestNet ? BybitConstants.OPTION_MAINNET : BybitConstants.OPTION_TESTNET;
        }
    }
}
