using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTaxnoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTaxnoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 默认值为false。true为输出交易信息，false为不输出交易信息。
        /// </summary>
        [XmlElement("enable_trade_out")]
        public string EnableTradeOut { get; set; }

        /// <summary>
        /// 查询结束时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        [XmlElement("end_invoice_date")]
        public string EndInvoiceDate { get; set; }

        /// <summary>
        /// 查询票种列表
        /// </summary>
        [XmlArray("invoice_kind_list")]
        [XmlArrayItem("string")]
        public List<string> InvoiceKindList { get; set; }

        /// <summary>
        /// 查询结果上限笔数，最大值20
        /// </summary>
        [XmlElement("limit_size")]
        public long LimitSize { get; set; }

        /// <summary>
        /// 当前页码，为空时默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 发票要素获取应用场景。<a href="https://opendocs.alipay.com/open/10691/bv8s88">"拉"模式报销</a> 固定为 INVOICE_EXPENSE 表示发票报销。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 查询起始时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        [XmlElement("start_invoice_date")]
        public string StartInvoiceDate { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
