using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimAdvancePaymentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimAdvancePaymentDTO : AopObject
    {
        /// <summary>
        /// 赔案号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 理赔报案单号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 收款账号名称
        /// </summary>
        [XmlElement("in_account_name")]
        public string InAccountName { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("in_account_no")]
        public string InAccountNo { get; set; }

        /// <summary>
        /// 收入账号类型
        /// </summary>
        [XmlElement("in_account_type")]
        public string InAccountType { get; set; }

        /// <summary>
        /// 支出账号名
        /// </summary>
        [XmlElement("out_account_name")]
        public string OutAccountName { get; set; }

        /// <summary>
        /// 支出账号
        /// </summary>
        [XmlElement("out_account_no")]
        public string OutAccountNo { get; set; }

        /// <summary>
        /// 支出账号类型
        /// </summary>
        [XmlElement("out_account_type")]
        public string OutAccountType { get; set; }

        /// <summary>
        /// 打款账单号
        /// </summary>
        [XmlElement("pay_bill_no")]
        public string PayBillNo { get; set; }

        /// <summary>
        /// 打款渠道类型： MYBANK_SHARE(网商银行分账), ALIPAY(支付宝打款), WXPAY(微信支付), CHINA_PAY(银联支付), BANK_CARD_PAY(银行卡支付), OTHER(其它)
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 打款金额
        /// </summary>
        [XmlElement("pay_fee")]
        public long PayFee { get; set; }

        /// <summary>
        /// 打款订单号
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }

        /// <summary>
        /// 打款业务单号
        /// </summary>
        [XmlElement("pay_out_biz_no")]
        public string PayOutBizNo { get; set; }

        /// <summary>
        /// 打款时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
