using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceapplydetailBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcTcnInvoiceapplydetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 开票申请明细
        /// </summary>
        [XmlElement("detail_list")]
        public InvoiceApplyDetail DetailList { get; set; }

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

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
