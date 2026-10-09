using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransInCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransInCardInfo : AopObject
    {
        /// <summary>
        /// 记账的外卡户名
        /// </summary>
        [XmlElement("bank_acc_name")]
        public string BankAccName { get; set; }

        /// <summary>
        /// 记账的外卡开户行
        /// </summary>
        [XmlElement("card_bank")]
        public string CardBank { get; set; }

        /// <summary>
        /// 记账的外卡支行
        /// </summary>
        [XmlElement("card_branch")]
        public string CardBranch { get; set; }

        /// <summary>
        /// 记账的外卡联航号
        /// </summary>
        [XmlElement("card_deposit")]
        public string CardDeposit { get; set; }

        /// <summary>
        /// 记账的外卡开户地址
        /// </summary>
        [XmlElement("card_location")]
        public string CardLocation { get; set; }

        /// <summary>
        /// 平台资金专户对应的记账的外卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }
    }
}
