using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceBillDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceBillDTO : AopObject
    {
        /// <summary>
        /// 金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 到票金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("arrival_amount")]
        public string ArrivalAmount { get; set; }

        /// <summary>
        /// 账期月
        /// </summary>
        [XmlElement("bill_cycle")]
        public string BillCycle { get; set; }

        /// <summary>
        /// 开票描述
        /// </summary>
        [XmlElement("bill_desc")]
        public string BillDesc { get; set; }

        /// <summary>
        /// 账单类型：合同 or 月账单
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 开票类型PREPAYorEXPENSE
        /// </summary>
        [XmlElement("billable_type")]
        public string BillableType { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("biz_document_no")]
        public string BizDocumentNo { get; set; }

        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_id")]
        public long BizId { get; set; }

        /// <summary>
        /// 已确认金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("confirmed_arrival_amount")]
        public string ConfirmedArrivalAmount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 减免金额（费用抵扣）（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 明细ID列表
        /// </summary>
        [XmlArray("detail_ids")]
        [XmlArrayItem("string")]
        public List<string> DetailIds { get; set; }

        /// <summary>
        /// 免除金额（允差处理）（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("discharge_amount")]
        public string DischargeAmount { get; set; }

        /// <summary>
        /// 明细JSON
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// KP单ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 开票账单号
        /// </summary>
        [XmlElement("invoice_bill_no")]
        public string InvoiceBillNo { get; set; }

        /// <summary>
        /// 开票抬头
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 预开票号
        /// </summary>
        [XmlElement("pre_invoice_bill_no")]
        public string PreInvoiceBillNo { get; set; }

        /// <summary>
        /// 是否红票
        /// </summary>
        [XmlElement("red")]
        public bool Red { get; set; }

        /// <summary>
        /// 关联单据号
        /// </summary>
        [XmlElement("related_document_no")]
        public string RelatedDocumentNo { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 同步状态
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 临时到票金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("temp_arrival_amount")]
        public string TempArrivalAmount { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("vendor_id")]
        public long VendorId { get; set; }

        /// <summary>
        /// 供应商店铺编号
        /// </summary>
        [XmlElement("vendor_user_id")]
        public string VendorUserId { get; set; }
    }
}
