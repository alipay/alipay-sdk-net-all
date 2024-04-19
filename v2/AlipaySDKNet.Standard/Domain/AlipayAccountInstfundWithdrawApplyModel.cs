using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountInstfundWithdrawApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountInstfundWithdrawApplyModel : AopObject
    {
        /// <summary>
        /// 提现卡户名
        /// </summary>
        [XmlElement("bank_card_name")]
        public string BankCardName { get; set; }

        /// <summary>
        /// 提现卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 提现银行联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 付款账号
        /// </summary>
        [XmlElement("debit_account_no")]
        public string DebitAccountNo { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("debit_amount")]
        public string DebitAmount { get; set; }

        /// <summary>
        /// 付款币种
        /// </summary>
        [XmlElement("debit_currency")]
        public string DebitCurrency { get; set; }

        /// <summary>
        /// 付款账号用户id
        /// </summary>
        [XmlElement("debit_user_id")]
        public string DebitUserId { get; set; }

        /// <summary>
        /// 附言字段
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部序列号，联合PID，幂等使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
