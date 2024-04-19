using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PriceDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PriceDetailDTO : AopObject
    {
        /// <summary>
        /// 奖品领取跳转链接
        /// </summary>
        [XmlElement("price_click_url")]
        public string PriceClickUrl { get; set; }

        /// <summary>
        /// 权益优惠信息
        /// </summary>
        [XmlElement("price_title")]
        public string PriceTitle { get; set; }
    }
}
