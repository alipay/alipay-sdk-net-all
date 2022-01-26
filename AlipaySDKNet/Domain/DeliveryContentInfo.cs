using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryContentInfo : AopObject
    {
        /// <summary>
        /// 活动对象，包括支付券和导码模式的商家券。
        /// </summary>
        [XmlElement("delivery_activity_content")]
        public DeliveryActivityContentInfo DeliveryActivityContent { get; set; }

        /// <summary>
        /// 枚举值： ACTIVITY：活动枚举类型。
        /// </summary>
        [XmlElement("delivery_content_type")]
        public string DeliveryContentType { get; set; }
    }
}
