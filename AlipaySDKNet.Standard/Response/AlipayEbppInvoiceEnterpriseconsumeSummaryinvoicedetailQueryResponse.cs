using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业汇总场景下，即企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 已废弃，开票批次 ID（建议使用summary_id）
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 批次状态<br/>     INIT：汇总批次初始化状态，未进行汇总<br/>     SUMMARY：汇总批次化汇总完成，汇总金额计算完成<br/>     PROCESS：汇总批次初始化状态，汇总开票申请提交成功<br/>     NOT_SUPPORT：汇总开票商户业务能力不支持<br/>     FAIL：汇总批次申请失败状态<br/>     SUCCESS：汇总批次申请成功状态，此时发票已回传<br/>     MANUAL_CONFIRM：汇总批次人工确认收票<br/>
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 发票内容
        /// </summary>
        [XmlArray("complete_voucher_list")]
        [XmlArrayItem("complete_voucher_info")]
        public List<CompleteVoucherInfo> CompleteVoucherList { get; set; }

        /// <summary>
        /// 账期结束时间
        /// </summary>
        [XmlElement("gmt_biz_end")]
        public string GmtBizEnd { get; set; }

        /// <summary>
        /// 账期起始时间
        /// </summary>
        [XmlElement("gmt_biz_start")]
        public string GmtBizStart { get; set; }

        /// <summary>
        /// 状态对应的展示明细内容<br/>     初始化<br/>     汇总完成<br/>     开票中...<br/>     不支持开票<br/>     开票失败<br/>     已开票<br/>     确认已收票<br/>
        /// </summary>
        [XmlElement("status_show_content")]
        public string StatusShowContent { get; set; }

        /// <summary>
        /// 开票批次 ID
        /// </summary>
        [XmlElement("summary_id")]
        public string SummaryId { get; set; }

        /// <summary>
        /// 企业汇总场景下，即企业ID（建议使用account_id）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
