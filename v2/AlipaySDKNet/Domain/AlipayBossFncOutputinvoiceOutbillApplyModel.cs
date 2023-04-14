using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceOutbillApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncOutputinvoiceOutbillApplyModel : AopObject
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
        /// 开票受理列表
        /// </summary>
        [XmlArray("invoice_applys")]
        [XmlArrayItem("invoice_apply_open_api")]
        public List<InvoiceApplyOpenApi> InvoiceApplys { get; set; }

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
        /// 申请人的uid号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 调用来源系统
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
