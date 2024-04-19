using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutputInvoiceRedApplyVO Data Structure.
    /// </summary>
    [Serializable]
    public class OutputInvoiceRedApplyVO : AopObject
    {
        /// <summary>
        /// 蓝字发票代码
        /// </summary>
        [XmlElement("blue_invoice_code")]
        public string BlueInvoiceCode { get; set; }

        /// <summary>
        /// 蓝字发票号， 传要红冲的那张发票的发票号
        /// </summary>
        [XmlElement("blue_invoice_no")]
        public string BlueInvoiceNo { get; set; }

        /// <summary>
        /// 发票介质 01 电子,02 纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 国际形势发票类型：41，42，43，44，04
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 红冲金额
        /// </summary>
        [XmlElement("red_amt")]
        public string RedAmt { get; set; }

        /// <summary>
        /// 红冲作废原因类型 投递失败退回：01，开票信息错误：02，其它：03，销货退回：04，服务终止：05，销售折让：06
        /// </summary>
        [XmlElement("red_invalid_reason_type")]
        public string RedInvalidReasonType { get; set; }

        /// <summary>
        /// 税务通知单号
        /// </summary>
        [XmlElement("red_notice_no")]
        public string RedNoticeNo { get; set; }

        /// <summary>
        /// 红冲原因
        /// </summary>
        [XmlElement("red_reason")]
        public string RedReason { get; set; }
    }
}
