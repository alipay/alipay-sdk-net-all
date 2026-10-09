using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonRelationSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonRelationSetModel : AopObject
    {
        /// <summary>
        /// 支心客的userId
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 支心客的openId
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 操作的类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }
    }
}
