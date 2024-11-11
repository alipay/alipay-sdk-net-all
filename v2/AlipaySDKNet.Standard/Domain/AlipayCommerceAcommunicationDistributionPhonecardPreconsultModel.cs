using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionPhonecardPreconsultModel : AopObject
    {
        /// <summary>
        /// 号卡办理人姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 号卡办理人身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 号卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 号卡归属地省份、城市编码
        /// </summary>
        [XmlElement("phone_card_address")]
        public PhoneCardAddressModel PhoneCardAddress { get; set; }
    }
}
