using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDeliveryPlayConfig Data Structure.
    /// </summary>
    [Serializable]
    public class IotDeliveryPlayConfig : AopObject
    {
        /// <summary>
        /// 投放展位的投放内容
        /// </summary>
        [XmlElement("delivery_content_info")]
        public IotDeliveryContentInfo DeliveryContentInfo { get; set; }
    }
}
