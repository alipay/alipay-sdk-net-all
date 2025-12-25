using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoiceQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseInvoiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有下一页 true:有 false:无
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 可开发票运单列表
        /// </summary>
        [XmlArray("invoice_waybill")]
        [XmlArrayItem("etc_corp_invoice_trade")]
        public List<EtcCorpInvoiceTrade> InvoiceWaybill { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
