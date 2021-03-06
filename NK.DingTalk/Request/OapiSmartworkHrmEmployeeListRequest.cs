using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.list
    /// </summary>
    public class OapiSmartworkHrmEmployeeListRequest : BaseDingTalkRequest<OapiSmartworkHrmEmployeeListResponse>
    {
        /// <summary>
        /// 需要获取的花名册字段信息
        /// </summary>
        public string FieldFilterList { get; set; }

        /// <summary>
        /// 员工id列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("field_filter_list", this.FieldFilterList);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("field_filter_list", this.FieldFilterList, 50);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 50);
        }

        #endregion
    }
}
