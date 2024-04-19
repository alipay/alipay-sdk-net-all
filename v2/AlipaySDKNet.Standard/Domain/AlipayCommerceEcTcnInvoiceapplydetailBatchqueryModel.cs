using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceapplydetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTcnInvoiceapplydetailBatchqueryModel : AopObject
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
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
