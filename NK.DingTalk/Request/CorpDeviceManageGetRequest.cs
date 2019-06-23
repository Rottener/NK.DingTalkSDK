using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.device.manage.get
    /// </summary>
    public class CorpDeviceManageGetRequest : BaseDingTalkRequest<CorpDeviceManageGetResponse>
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备服务商ID
        /// </summary>
        public Nullable<long> DeviceServiceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.device.manage.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("device_service_id", this.DeviceServiceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("device_service_id", this.DeviceServiceId);
        }

        #endregion
    }
}