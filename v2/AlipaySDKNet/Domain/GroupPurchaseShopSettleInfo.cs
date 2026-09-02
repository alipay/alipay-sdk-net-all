using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseShopSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseShopSettleInfo : AopObject
    {
        /// <summary>
        /// 结算到户的账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 店铺银行卡信息
        /// </summary>
        [XmlElement("bank_card")]
        public GroupPurchaseBankCard BankCard { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
