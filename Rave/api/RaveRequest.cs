﻿using System.Net.Http;
using System.Net.Http.Headers;
using Rave.data;

namespace Rave.api
{
    internal class RaveRequest : RaveRequestBase<RaveResponse<ChargeResponse>, ChargeResponse>
    {
       
    }

    internal class RaveRequest<T1, T2> : RaveRequestBase<T1, T2> where T1 : RaveResponse<T2>, new() where T2 : class
    {
        internal RaveRequest():base()
        {
            Config = new raveConfig(false);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        internal RaveRequest(raveConfig config): base(config)
        {
            Config = config;
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

       
    }
}
