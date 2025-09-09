using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MrchCashierInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MrchCashierInfo : AopObject
    {
        /// <summary>
        /// 收银员Id
        /// </summary>
        [XmlElement("cashier_id")]
        public string CashierId { get; set; }

        /// <summary>
        /// 收银员名称
        /// </summary>
        [XmlElement("cashier_name")]
        public string CashierName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 所属门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
