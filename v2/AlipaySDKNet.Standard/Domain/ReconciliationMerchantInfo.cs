using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReconciliationMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReconciliationMerchantInfo : AopObject
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("merchant_credit_no")]
        public string MerchantCreditNo { get; set; }

        /// <summary>
        /// 商家支付宝账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
