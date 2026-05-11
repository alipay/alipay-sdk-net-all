using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResaleDeliveryVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResaleDeliveryVO : AopObject
    {
        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_bill_no")]
        public string LogisticsBillNo { get; set; }

        /// <summary>
        /// 按照本文规范传入 https://opendocs.alipay.com/mini/07hva0?pathHash=5de3c48d
        /// </summary>
        [XmlElement("logistics_platform")]
        public string LogisticsPlatform { get; set; }
    }
}
