using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopSettleInfo : AopObject
    {
        /// <summary>
        /// 结算到户的账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 门店结算银行卡信息（特殊可选），结算到卡时必填
        /// </summary>
        [XmlElement("bank_cards")]
        public ShopBankCard BankCards { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
