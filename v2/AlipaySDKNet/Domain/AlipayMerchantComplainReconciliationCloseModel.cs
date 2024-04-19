using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainReconciliationCloseModel : AopObject
    {
        /// <summary>
        /// 商家支付宝侧账号，唯一标识
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家类型，默认为DIRECT
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
