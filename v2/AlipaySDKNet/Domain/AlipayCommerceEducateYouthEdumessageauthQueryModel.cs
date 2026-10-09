using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateYouthEdumessageauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateYouthEdumessageauthQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型，用于区分不同业务场景
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 消息发送者AppId
        /// </summary>
        [XmlElement("from_app_id")]
        public string FromAppId { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 消息类型(最多三个)
        /// </summary>
        [XmlArray("msg_enum_list")]
        [XmlArrayItem("string")]
        public List<string> MsgEnumList { get; set; }

        /// <summary>
        /// 消息接收者openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 消息接收者UID
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
