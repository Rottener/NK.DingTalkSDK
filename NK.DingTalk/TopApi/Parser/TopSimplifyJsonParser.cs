﻿using NK.DingTalk.FastJSON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NK.DingTalk.TopApi.Parser
{
    public class TopSimplifyJsonParser<T> : TopJsonParser<T> where T : TopResponse
    {
        public override T Parse(string body)
        {
            T rsp = null;

            IDictionary rootJson = JSON.Parse(body) as IDictionary;
            if (rootJson != null)
            {
                IDictionary data = rootJson;
                if (rootJson.Contains(Constants.ERROR_RESPONSE))
                {
                    data = rootJson[Constants.ERROR_RESPONSE] as IDictionary;
                }

                if (data != null)
                {
                    ITopReader reader = new TopSimplifyJsonReader(data);
                    rsp = (T)FromJson(reader, typeof(T));
                }
            }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
            }

            return rsp;
        }
    }
}
