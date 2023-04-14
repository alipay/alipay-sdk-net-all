using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIAccountingAcceptance Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIAccountingAcceptance : AopObject
    {
        /// <summary>
        /// 金额Map
        /// </summary>
        [XmlElement("amount_map")]
        public string AmountMap { get; set; }

        /// <summary>
        /// 业务单据号组合字段，用于业财一体化的追溯，如存款场景下需要银行流水号用于对账、报账场景下需要报账单号用于追溯报账相关业务信息，一个业务事件可能关联多业务单据信息（如应收核销应付，关联应收单与应付单），采用组合字段，包括单据类型及其主键ID
        /// </summary>
        [XmlElement("biz_bill_nos_map")]
        public string BizBillNosMap { get; set; }

        /// <summary>
        /// 业务要素
        /// </summary>
        [XmlElement("biz_elements")]
        public string BizElements { get; set; }

        /// <summary>
        /// 业务事件码（8位数字）
        /// </summary>
        [XmlElement("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 端事件码（8位数字）
        /// </summary>
        [XmlElement("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [XmlElement("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 高精度金额
        /// </summary>
        [XmlElement("high_amount_map")]
        public string HighAmountMap { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 记账备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 业务流水号（受理幂等字段之一）
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 业务唯一标识（受理幂等字段之一）
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 业务流水子单号（受理幂等字段之一）
        /// </summary>
        [XmlElement("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("system_origin")]
        public string SystemOrigin { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
