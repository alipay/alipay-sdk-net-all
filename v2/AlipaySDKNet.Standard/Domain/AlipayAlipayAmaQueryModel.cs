using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAlipayAmaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAlipayAmaQueryModel : AopObject
    {
        /// <summary>
        /// 自定义业务
        /// </summary>
        [XmlElement("biz")]
        public string Biz { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 用户标识，唯一标记用户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 这是什么
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 唯一标识当前问题
        /// </summary>
        [XmlElement("query_id")]
        public string QueryId { get; set; }

        /// <summary>
        /// 唯一标识一个会话
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
