using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentBusinessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentBusinessInfo : AopObject
    {
        /// <summary>
        /// 开放结果页复杂场景优惠信息
        /// </summary>
        [XmlArray("discounts")]
        [XmlArrayItem("custom_info")]
        public List<CustomInfo> Discounts { get; set; }

        /// <summary>
        /// 开放结果页复杂场景其他信息
        /// </summary>
        [XmlArray("other")]
        [XmlArrayItem("custom_info")]
        public List<CustomInfo> Other { get; set; }

        /// <summary>
        /// 开放结果页复杂场景付款方式
        /// </summary>
        [XmlArray("payments")]
        [XmlArrayItem("custom_info")]
        public List<CustomInfo> Payments { get; set; }
    }
}
