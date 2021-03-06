using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.updaterole
    /// </summary>
    public class OapiRoleUpdateroleRequest : BaseDingTalkRequest<OapiRoleUpdateroleResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public Nullable<long> RoleId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string RoleName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.updaterole";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("roleId", this.RoleId);
            parameters.Add("roleName", this.RoleName);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("roleId", this.RoleId);
            RequestValidator.ValidateRequired("roleName", this.RoleName);
        }

        #endregion
    }
}
