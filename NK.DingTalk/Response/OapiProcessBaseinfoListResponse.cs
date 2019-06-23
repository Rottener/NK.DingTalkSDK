using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using NK.DingTalk.TopApi;

namespace NK.DingTalk.Response
{
    /// <summary>
    /// OapiProcessBaseinfoListResponse.
    /// </summary>
    public class OapiProcessBaseinfoListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 模板对象列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("process_top_vo")]
        public List<ProcessTopVoDomain> Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ProcessTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessTopVoDomain : TopObject
{
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 管理员userId列表
	        /// </summary>
	        [XmlArray("manager_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ManagerUserIds { get; set; }
	
	        /// <summary>
	        /// 模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否开启自定义打印
	        /// </summary>
	        [XmlElement("open_custom_print")]
	        public bool OpenCustomPrint { get; set; }
	
	        /// <summary>
	        /// 模板code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

    }
}