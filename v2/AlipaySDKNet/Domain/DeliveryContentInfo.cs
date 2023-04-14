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
        /// 活动对象。
        /// </summary>
        [XmlElement("delivery_activity_content")]
        public DeliveryActivityContentInfo DeliveryActivityContent { get; set; }

        /// <summary>
        /// 小程序对象
        /// </summary>
        [XmlElement("delivery_app_content")]
        public DeliveryMiniAppContentInfo DeliveryAppContent { get; set; }

        /// <summary>
        /// 枚举值： ACTIVITY：活动枚举类型， MINI_APP：小程序枚举类型
        /// </summary>
        [XmlElement("delivery_content_type")]
        public string DeliveryContentType { get; set; }
    }
}
