using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArInvoiceReturnOrderDetailOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ArInvoiceReturnOrderDetailOpenApiResponse : AopObject
    {
        /// <summary>
        /// 附件地址
        /// </summary>
        [XmlArray("attach_urls")]
        [XmlArrayItem("string")]
        public List<string> AttachUrls { get; set; }

        /// <summary>
        /// 是否通过税务认证 true 通过, false 不通过
        /// </summary>
        [XmlElement("auth")]
        public bool Auth { get; set; }

        /// <summary>
        /// 申请人，标识是谁创建的这条记录
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 申请创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 申请最后一次的修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 票面金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期 格式(yyyyMMdd)
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态; 01:待开票； 02:开票中; 03:已开票; 04:作废中; 05:已作废; 06:红冲中; 07:已红冲; 08:部分红冲; 09:无效;
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票种类 01 专票;02 普票;03 营业税发票;04 国际形式发票;05 其它发票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 最后修改人，标识最后操作这条数据的人
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 申请编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 重开发票代码
        /// </summary>
        [XmlElement("re_invoice_code")]
        public string ReInvoiceCode { get; set; }

        /// <summary>
        /// 重开发票ID
        /// </summary>
        [XmlElement("re_invoice_id")]
        public string ReInvoiceId { get; set; }

        /// <summary>
        /// 重开发票号码
        /// </summary>
        [XmlElement("re_invoice_no")]
        public string ReInvoiceNo { get; set; }

        /// <summary>
        /// 红冲税务通知单号
        /// </summary>
        [XmlElement("red_notice_no")]
        public string RedNoticeNo { get; set; }

        /// <summary>
        /// 退换票申请明细ID
        /// </summary>
        [XmlElement("return_order_detail_id")]
        public string ReturnOrderDetailId { get; set; }
    }
}
