using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiApplyInvoiceOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiApplyInvoiceOrder : AopObject
    {
        /// <summary>
        /// 调用方身份识别标记(应用名称) 与业务单据号联合唯一 必填
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务单据号，业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 开票总金额，开票金额不能为空，开票金额不能小于等于0
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 开票账单集合
        /// </summary>
        [XmlArray("invoice_bill_items")]
        [XmlArrayItem("invoice_bill_item")]
        public List<InvoiceBillItem> InvoiceBillItems { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 申请人的2088账号，小二传工号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 申请人的2088账号，小二传工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人类型ALIPAY_UID代表2088UID，ALIPAY_OPENID代表openID，WORK_ID代表工号
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 系统来源，描述该请求来自于哪个系统
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
