using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankActivityInfo : AopObject
    {
        /// <summary>
        /// 是否绑定银行卡
        /// </summary>
        [XmlElement("bind_card")]
        public bool BindCard { get; set; }

        /// <summary>
        /// 银行卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [XmlElement("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 活动logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }
    }
}
