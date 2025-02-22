﻿using bybit.net.api.Websockets;
using System.Net.WebSockets;

namespace bybit.net.api.WebSocketStream
{
    public class BybitInverseWebSocket : BybitWebSocket
    {
        public BybitInverseWebSocket(bool useTestNet = false, int pingIntevral = 20, int receiveBufferSize = 8192, string? apiKey = null, string? apiSecret = null)
            : base(new BybitWebSocketHandler(new ClientWebSocket()), GetStreamUrl(useTestNet), pingIntevral, receiveBufferSize, apiKey, apiSecret)
        {
        }

        public BybitInverseWebSocket(IBybitWebSocketHandler handler, bool useTestNet = false, int pingIntevral = 20, int receiveBufferSize = 8192, string? apiKey = null, string? apiSecret = null)
            : base(handler, GetStreamUrl(useTestNet), pingIntevral, receiveBufferSize, apiKey, apiSecret)
        {
        }

        private static string GetStreamUrl(bool useTestNet)
        {
            return !useTestNet ? BybitConstants.INVERSE_MAINNET : BybitConstants.INVERSE_TESTNET;
        }
    }
}
