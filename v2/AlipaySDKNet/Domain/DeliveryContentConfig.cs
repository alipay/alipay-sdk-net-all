using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryContentConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryContentConfig : AopObject
    {
        /// <summary>
        /// 投放引导信息
        /// </summary>
        [XmlElement("delivery_send_guide")]
        public DeliverySendGuide DeliverySendGuide { get; set; }
    }
}
