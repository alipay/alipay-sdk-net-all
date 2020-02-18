using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeDepositVerifyApplyModel : AopObject
    {
        /// <summary>
        /// 待认证银行卡户名
        /// </summary>
        [XmlElement("bank_card_name")]
        public string BankCardName { get; set; }

        /// <summary>
        /// 待认证银行卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 人行联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 成员机构会员ID
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 手机号码 用于接收打款验证通知短信
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 业务场景编码，如需要由网商分配
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
