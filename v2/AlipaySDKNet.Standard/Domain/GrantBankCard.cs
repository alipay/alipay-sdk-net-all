using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GrantBankCard Data Structure.
    /// </summary>
    [Serializable]
    public class GrantBankCard : AopObject
    {
        /// <summary>
        /// 支付宝绑卡唯一ID
        /// </summary>
        [XmlElement("bank_card_id")]
        public string BankCardId { get; set; }

        /// <summary>
        /// 支付宝侧存储的银行编码，可能跟外域编码规则不一致
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 展示的银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 展示用户的银行卡号后四位
        /// </summary>
        [XmlElement("show_card_no")]
        public string ShowCardNo { get; set; }
    }
}
