using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTcnInvoiceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 平台申请ID
        /// </summary>
        [XmlElement("platform_apply_id")]
        public string PlatformApplyId { get; set; }
    }
}
