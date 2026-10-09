using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureCertificateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsureCertificateDTO : AopObject
    {
        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 产品编码:YFX(运费险),JYBZ(交易保障险),SHX(售后险）
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 报价id
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 推荐流水id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }
    }
}
