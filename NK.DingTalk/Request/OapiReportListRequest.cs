using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.report.list
    /// </summary>
    public class OapiReportListRequest : BaseDingTalkRequest<OapiReportListResponse>
    {
        /// <summary>
        /// 查询游标，初始传入0，后续从上一次的返回值中获取
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 查询截止时间
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 每页数据量
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 查询起始时间
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 要查询的模板名称
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// 员工的userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.report.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("size", this.Size);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("template_name", this.TemplateName);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
        }

        #endregion
    }
}
