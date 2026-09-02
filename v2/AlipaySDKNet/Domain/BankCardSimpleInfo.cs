using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankCardSimpleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankCardSimpleInfo : AopObject
    {
        /// <summary>
        /// 银行卡code
        /// </summary>
        [XmlElement("bank_card_code")]
        public string BankCardCode { get; set; }

        /// <summary>
        /// 银行卡名称
        /// </summary>
        [XmlElement("bank_card_name")]
        public string BankCardName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }
    }
}
