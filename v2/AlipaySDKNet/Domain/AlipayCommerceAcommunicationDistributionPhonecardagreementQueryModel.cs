using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardagreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionPhonecardagreementQueryModel : AopObject
    {
        /// <summary>
        /// 办理人姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 办理人身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 办理人联系电话
        /// </summary>
        [XmlElement("contact_phone_number")]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// 号卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 号卡归属地省市编码，非选号可不填
        /// </summary>
        [XmlElement("phone_card_address")]
        public PhoneCardAddressModel PhoneCardAddress { get; set; }

        /// <summary>
        /// 用户选占的手机号，非选号商品可不传
        /// </summary>
        [XmlElement("phone_num")]
        public string PhoneNum { get; set; }
    }
}
