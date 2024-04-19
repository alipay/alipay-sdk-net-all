using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIReverseBillAcceptance Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIReverseBillAcceptance : AopObject
    {
        /// <summary>
        /// 摊销扩展信息
        /// </summary>
        [XmlElement("amortize_ext_info")]
        public GFAOpenAPIAmortizeExtInfo AmortizeExtInfo { get; set; }

        /// <summary>
        /// 签约合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 业务账单金额。（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

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
        /// ISO 4217货币币种数值
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 受理方向
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 收费事件码（8位数字）
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 业务系统收付款完成时间（GMT+8时区，不能晚于系统当前时间）
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 指定收付款时间（GMT+8时区）
        /// </summary>
        [XmlElement("gmt_receive")]
        public string GmtReceive { get; set; }

        /// <summary>
        /// 业务发生时间（GMT+8时区，不能晚于系统当前时间）
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 业务系统未收付金额（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [XmlElement("nonpayment_amount")]
        public string NonpaymentAmount { get; set; }

        /// <summary>
        /// 业务逆向流水号（受理幂等字段之一）
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 业务系统收付款状态
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 收款参与者信息
        /// </summary>
        [XmlElement("payee_participant")]
        public GFAOpenAPIParticipantInfo PayeeParticipant { get; set; }

        /// <summary>
        /// 付款参与者信息
        /// </summary>
        [XmlElement("payer_participant")]
        public GFAOpenAPIParticipantInfo PayerParticipant { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业财受理账单扩展信息。Map<String, String> 类型JSON字符串。
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 业务系统已收付金额（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 逆向关联的正向流水号
        /// </summary>
        [XmlElement("rel_out_business_no")]
        public string RelOutBusinessNo { get; set; }

        /// <summary>
        /// 逆向关联的正向流水子单号
        /// </summary>
        [XmlElement("rel_sub_out_business_no")]
        public string RelSubOutBusinessNo { get; set; }

        /// <summary>
        /// 业务发生量/业务发生金额。如果是金额，则为各币种的“元”单位，精确到小数点后两位。
        /// </summary>
        [XmlElement("service_amount")]
        public long ServiceAmount { get; set; }

        /// <summary>
        /// 业务唯一标识（受理幂等字段之一）
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 指定结算参与者信息
        /// </summary>
        [XmlElement("settle_participant")]
        public GFAOpenAPIParticipantInfo SettleParticipant { get; set; }

        /// <summary>
        /// 签约参与者信息
        /// </summary>
        [XmlElement("sign_participant")]
        public GFAOpenAPIParticipantInfo SignParticipant { get; set; }

        /// <summary>
        /// 业务逆向流水子单号（受理幂等字段之一）
        /// </summary>
        [XmlElement("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 来源系统名
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
