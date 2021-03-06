using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using NK.DingTalk.TopApi;

namespace NK.DingTalk.Response
{
    /// <summary>
    /// OapiMessageCorpconversationGetsendresultResponse.
    /// </summary>
    public class OapiMessageCorpconversationGetsendresultResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("send_result")]
        public AsyncSendResultDomain SendResult { get; set; }

	/// <summary>
/// AsyncSendResultDomain Data Structure.
/// </summary>
[Serializable]

public class AsyncSendResultDomain : TopObject
{
	        /// <summary>
	        /// 发送失败的用户id
	        /// </summary>
	        [XmlArray("failed_user_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> FailedUserIdList { get; set; }
	
	        /// <summary>
	        /// 因发送消息过于频繁或超量而被流控过滤后实际未发送的userid。未被限流的接收者仍会被成功发送。限流规则包括：1、给同一用户发相同内容消息一天仅允许一次；2、如果是ISV接入方式，给同一用户发消息一天不得超过100次；如果是企业接入方式，此上限为500。
	        /// </summary>
	        [XmlArray("forbidden_user_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> ForbiddenUserIdList { get; set; }
	
	        /// <summary>
	        /// 无效的部门id
	        /// </summary>
	        [XmlArray("invalid_dept_id_list")]
	        [XmlArrayItem("number")]
	        public List<long> InvalidDeptIdList { get; set; }
	
	        /// <summary>
	        /// 无效的用户id
	        /// </summary>
	        [XmlArray("invalid_user_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> InvalidUserIdList { get; set; }
	
	        /// <summary>
	        /// 已读消息的用户id
	        /// </summary>
	        [XmlArray("read_user_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> ReadUserIdList { get; set; }
	
	        /// <summary>
	        /// 未读消息的用户id
	        /// </summary>
	        [XmlArray("unread_user_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> UnreadUserIdList { get; set; }
}

    }
}
