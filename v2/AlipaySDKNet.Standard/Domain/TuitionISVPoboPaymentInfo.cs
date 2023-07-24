using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVPoboPaymentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVPoboPaymentInfo : AopObject
    {
        /// <summary>
        /// amount+留学VCC场景
        /// </summary>
        [XmlElement("amount")]
        public TuitionMoneyDTO Amount { get; set; }

        /// <summary>
        /// 卡品牌+留学VCC场景
        /// </summary>
        [XmlElement("card_brand")]
        public string CardBrand { get; set; }

        /// <summary>
        /// 卡过期时间+留学缴费VCC场景
        /// </summary>
        [XmlElement("card_expiry_date")]
        public string CardExpiryDate { get; set; }

        /// <summary>
        /// 持卡人地址+留学缴费VCC
        /// </summary>
        [XmlElement("card_holder_address")]
        public TuitionAddress CardHolderAddress { get; set; }

        /// <summary>
        /// 持卡人姓名+留学缴费VCC场景
        /// </summary>
        [XmlElement("card_holder_name")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// VCC卡号+留学缴费VCC
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡生效时间+留学缴费VCC场景
        /// </summary>
        [XmlElement("card_start_date")]
        public string CardStartDate { get; set; }

        /// <summary>
        /// cvv+留学缴费VCC场景
        /// </summary>
        [XmlElement("cvv")]
        public string Cvv { get; set; }
    }
}
