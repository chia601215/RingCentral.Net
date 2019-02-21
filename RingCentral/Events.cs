using System;
using System.Net.Http;

namespace RingCentral
{
    public class HttpCallEventArgs : EventArgs
    {
        public HttpResponseMessage httpResponseMessage;
        public HttpRequestMessage httpRequestMessage;

        public HttpCallEventArgs(HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage)
        {
            this.httpResponseMessage = httpResponseMessage;
            this.httpRequestMessage = httpRequestMessage;
        }
    }

    public partial class RestClient
    {
        public event EventHandler<HttpCallEventArgs> AfterHttpCall;
    }

    public class TokenEventArgs : EventArgs
    {
        public TokenInfo Token;

        public TokenEventArgs(TokenInfo token)
        {
            Token = token;
        }
    }

    public partial class RestClient
    {
        public event EventHandler<TokenEventArgs> TokenRefreshed;
    }
}