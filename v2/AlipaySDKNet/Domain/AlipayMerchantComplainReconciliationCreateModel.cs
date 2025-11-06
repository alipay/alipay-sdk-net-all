using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainReconciliationCreateModel : AopObject
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("merchant_cert_no")]
        public string MerchantCertNo { get; set; }
    }
}
