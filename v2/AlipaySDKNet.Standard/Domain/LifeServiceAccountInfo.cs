using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceAccountInfo : AopObject
    {
        /// <summary>
        /// 账户状态
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 结算账号
        /// </summary>
        [XmlElement("settle_account_id")]
        public string SettleAccountId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
