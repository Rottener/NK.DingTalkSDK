using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.getuserinfo
    /// </summary>
    public class OapiUserGetuserinfoRequest : BaseDingTalkRequest<OapiUserGetuserinfoResponse>
    {
        /// <summary>
        /// requestAuthCode接口中获取的CODE
        /// </summary>
        public string Code { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.getuserinfo";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
