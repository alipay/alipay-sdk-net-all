using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantActivityQueryModel : AopObject
    {
        /// <summary>
        /// 模版ID
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// MERCHANT_INTEREST_SUBSIDY_MIXED 代表新活动，模版ID以mixed开头；其他为 MERCHANT_INTEREST_SUBSIDY_THIRDPARTY 代表老活动
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
