using System;
using System.Collections.Generic;
using NK.DingTalk.TopApi.Util;
using NK.DingTalk.TopApi;
using NK.DingTalk.Response;

namespace NK.DingTalk.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.create
    /// </summary>
    public class OapiMicroappCreateRequest : BaseDingTalkRequest<OapiMicroappCreateResponse>
    {
        /// <summary>
        /// 钉钉测试微应用
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 微应用的图标。需要调用上传接口将图标上传到钉钉服务器后获取到的mediaId
        /// </summary>
        public string AppIcon { get; set; }

        /// <summary>
        /// 微应用的名称。长度限制为1~10个字符
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 微应用的移动端主页，必须以http开头或https开头
        /// </summary>
        public string HomepageUrl { get; set; }

        /// <summary>
        /// 微应用的OA后台管理主页，必须以http开头或https开头。微应用后台管理员免登 开发
        /// </summary>
        public string OmpLink { get; set; }

        /// <summary>
        /// 微应用的PC端主页，必须以http开头或https开头，如果不为空则必须与homepageUrl的域名一致
        /// </summary>
        public string PcHomepageUrl { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appDesc", this.AppDesc);
            parameters.Add("appIcon", this.AppIcon);
            parameters.Add("appName", this.AppName);
            parameters.Add("homepageUrl", this.HomepageUrl);
            parameters.Add("ompLink", this.OmpLink);
            parameters.Add("pcHomepageUrl", this.PcHomepageUrl);
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