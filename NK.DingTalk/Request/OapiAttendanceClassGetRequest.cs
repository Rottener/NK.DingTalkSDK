using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.class.get
    /// </summary>
    public class OapiAttendanceClassGetRequest : BaseDingTalkRequest<OapiAttendanceClassGetResponse>
    {
        /// <summary>
        /// 班次id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.class.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("class_id", this.ClassId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
        }

        #endregion
    }
}