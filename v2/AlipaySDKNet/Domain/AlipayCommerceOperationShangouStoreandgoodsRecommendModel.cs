using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationShangouStoreandgoodsRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationShangouStoreandgoodsRecommendModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 位置纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 位置经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户聊天内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 智能体会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
