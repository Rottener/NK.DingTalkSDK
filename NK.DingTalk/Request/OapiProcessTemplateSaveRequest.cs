using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.template.save
    /// </summary>
    public class OapiProcessTemplateSaveRequest : BaseDingTalkRequest<OapiProcessTemplateSaveResponse>
    {
        /// <summary>
        /// 字体
        /// </summary>
        public string Font { get; set; }

        /// <summary>
        /// 流程编码
        /// </summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// vm文件
        /// </summary>
        public string Vm { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.template.save";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("font", this.Font);
            parameters.Add("process_code", this.ProcessCode);
            parameters.Add("vm", this.Vm);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("font", this.Font);
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
            RequestValidator.ValidateRequired("vm", this.Vm);
        }

        #endregion
    }
}