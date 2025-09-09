using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBenefitInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalBenefitInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益商品id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 是否可售卖
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [XmlElement("out_benefit_id")]
        public string OutBenefitId { get; set; }

        /// <summary>
        /// sku信息
        /// </summary>
        [XmlElement("sku_info")]
        public string SkuInfo { get; set; }
    }
}
