using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantPageBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIndirectmerchantPageBatchqueryModel : AopObject
    {
        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 经营状态
        /// </summary>
        [XmlElement("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
