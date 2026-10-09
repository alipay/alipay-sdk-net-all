using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookCardQueryResponse.
    /// </summary>
    public class AlipayFundAccountbookCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 记账本外卡卡号
        /// </summary>
        [XmlElement("account_book_card_no")]
        public string AccountBookCardNo { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 记账本的外卡户名
        /// </summary>
        [XmlElement("bank_acc_name")]
        public string BankAccName { get; set; }

        /// <summary>
        /// 记账本的外卡开户行
        /// </summary>
        [XmlElement("card_bank")]
        public string CardBank { get; set; }

        /// <summary>
        /// 记账本的外卡支行
        /// </summary>
        [XmlElement("card_branch")]
        public string CardBranch { get; set; }

        /// <summary>
        /// 记账本的外卡联行号
        /// </summary>
        [XmlElement("card_deposit")]
        public string CardDeposit { get; set; }

        /// <summary>
        /// 记账本的外卡开户地址
        /// </summary>
        [XmlElement("card_location")]
        public string CardLocation { get; set; }

        /// <summary>
        /// 记账的外卡状态, A：正常状态; 其他：异常
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
