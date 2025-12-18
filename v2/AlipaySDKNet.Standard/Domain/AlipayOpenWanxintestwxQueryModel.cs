using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenWanxintestwxQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenWanxintestwxQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 测试 当前字段已废弃(111111)
        /// </summary>
        [XmlElement("op")]
        public string Op { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("ty")]
        public string Ty { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
