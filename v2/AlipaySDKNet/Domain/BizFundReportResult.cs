using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizFundReportResult Data Structure.
    /// </summary>
    [Serializable]
    public class BizFundReportResult : AopObject
    {
        /// <summary>
        /// 实付金额（元）
        /// </summary>
        [XmlElement("alipay_amount")]
        public string AlipayAmount { get; set; }

        /// <summary>
        /// 是否批量转账
        /// </summary>
        [XmlElement("batch_type")]
        public string BatchType { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务类型描述
        /// </summary>
        [XmlElement("biz_type_desc")]
        public string BizTypeDesc { get; set; }

        /// <summary>
        /// 服务费（元）
        /// </summary>
        [XmlElement("charge_fee")]
        public string ChargeFee { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 2020xxx
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 出借
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否脱敏
        /// </summary>
        [XmlElement("no_mbill_encrypt")]
        public string NoMbillEncrypt { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 实付金额（元）
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 收款方银行卡号
        /// </summary>
        [XmlElement("payee_card_no")]
        public string PayeeCardNo { get; set; }

        /// <summary>
        /// 收款方全名
        /// </summary>
        [XmlElement("payee_full_name")]
        public string PayeeFullName { get; set; }

        /// <summary>
        /// 收款方资金类型
        /// </summary>
        [XmlElement("payee_fund_type")]
        public string PayeeFundType { get; set; }

        /// <summary>
        /// 支付宝余额
        /// </summary>
        [XmlElement("payee_fund_type_desc")]
        public string PayeeFundTypeDesc { get; set; }

        /// <summary>
        /// 收款银行中文简称
        /// </summary>
        [XmlElement("payee_inst_name")]
        public string PayeeInstName { get; set; }

        /// <summary>
        /// 收款方登录Id
        /// </summary>
        [XmlElement("payee_login_email")]
        public string PayeeLoginEmail { get; set; }

        /// <summary>
        /// 收款方姓名
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 付款方资金类型
        /// </summary>
        [XmlElement("payer_fund_type")]
        public string PayerFundType { get; set; }

        /// <summary>
        /// 付款方资金类型描述
        /// </summary>
        [XmlElement("payer_fund_type_desc")]
        public string PayerFundTypeDesc { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 是否展示细节，默认为true
        /// </summary>
        [XmlElement("show_detail")]
        public string ShowDetail { get; set; }

        /// <summary>
        /// 是否出示凭证
        /// </summary>
        [XmlElement("show_voucher")]
        public string ShowVoucher { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 单据状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 业务子类型
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 业务子类型描述
        /// </summary>
        [XmlElement("sub_biz_type_desc")]
        public string SubBizTypeDesc { get; set; }
    }
}
