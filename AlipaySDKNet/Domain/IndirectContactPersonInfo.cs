using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectContactPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectContactPersonInfo : AopObject
    {
        /// <summary>
        /// 联系人身份证号
        /// </summary>
        [XmlElement("contact_card_no")]
        public string ContactCardNo { get; set; }

        /// <summary>
        /// 联系人证件类型，枚举值：中国大陆居民-身份证(RESIDENT)、其他国家或地区居民-护照(PASSPORT)、中国港澳居民-来往内地通行证(PASSPORT_HK_MO)、中国台湾居民-来往大陆通行证(PASSPORT_TWN)、港澳居民居住证（RESIDENCE_PERMIT_HM）、台湾居民居住证（RESIDENCE_PERMIT_TW）、外国人永久居住证（PERMANENT_RESIDENCE_FOREIGNER）。个体户/企业/事业单位/社会组织：可选择任一证件类型。小微商户仅支持身份证类型。
        /// </summary>
        [XmlElement("contact_cert_type")]
        public string ContactCertType { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [XmlElement("contact_phone_no")]
        public string ContactPhoneNo { get; set; }
    }
}
