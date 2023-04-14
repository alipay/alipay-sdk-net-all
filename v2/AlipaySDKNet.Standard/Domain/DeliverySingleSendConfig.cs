using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliverySingleSendConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DeliverySingleSendConfig : AopObject
    {
        /// <summary>
        /// 推广内容配置
        /// </summary>
        [XmlElement("delivery_content_config")]
        public DeliveryContentConfig DeliveryContentConfig { get; set; }

        /// <summary>
        /// 投放展位的投放内容。
        /// </summary>
        [XmlElement("delivery_content_info")]
        public DeliveryContentInfo DeliveryContentInfo { get; set; }
    }
}
