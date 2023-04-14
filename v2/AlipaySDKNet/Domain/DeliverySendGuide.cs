using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliverySendGuide Data Structure.
    /// </summary>
    [Serializable]
    public class DeliverySendGuide : AopObject
    {
        /// <summary>
        /// 引导链接，从支付宝公域跳转到服务商(商户)承接页的引导链接。
        /// </summary>
        [XmlElement("delivery_guide_url")]
        public string DeliveryGuideUrl { get; set; }
    }
}
