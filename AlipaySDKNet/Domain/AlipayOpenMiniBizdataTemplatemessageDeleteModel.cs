using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniBizdataTemplatemessageDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBizdataTemplatemessageDeleteModel : AopObject
    {
        /// <summary>
        /// 商户业务流水id，应该是商户侧数据的唯一键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
