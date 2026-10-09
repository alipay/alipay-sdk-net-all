using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentInfo : AopObject
    {
        /// <summary>
        /// 回款金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 回款失败原因，仅 repayment_status = FAIL 时填写
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 回款时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 外部平台全局唯一流水号，扣款咨询阶段外部平台返回
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 预付回款业务的收款钱包编号
        /// </summary>
        [XmlElement("payee_wallet_id")]
        public string PayeeWalletId { get; set; }

        /// <summary>
        /// 预付回款业务的回款方钱包编号，对应专户发薪收款钱包编号
        /// </summary>
        [XmlElement("payer_wallet_id")]
        public string PayerWalletId { get; set; }

        /// <summary>
        /// 回款状态
        /// </summary>
        [XmlElement("repayment_status")]
        public string RepaymentStatus { get; set; }
    }
}
