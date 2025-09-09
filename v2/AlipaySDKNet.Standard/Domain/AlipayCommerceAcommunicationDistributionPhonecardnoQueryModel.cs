using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardnoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionPhonecardnoQueryModel : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 号卡归属地
        /// </summary>
        [XmlElement("phone_card_address")]
        public PhoneCardAddressModel PhoneCardAddress { get; set; }
    }
}
