using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectLegalPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectLegalPersonInfo : AopObject
    {
        /// <summary>
        /// 授权函照片（使用图片上传接口），当证件持有人类型为 经办人时，必须上传。其他情况，无需上传
        /// </summary>
        [XmlElement("auth_letter_img")]
        public string AuthLetterImg { get; set; }

        /// <summary>
        /// 法人/经营者证件反面照（使用图片上传接口的image_id）。当证件类型为身份证时，此字段必传；当证件类型为非身份证时，此字段非必传。
        /// </summary>
        [XmlElement("card_back_img")]
        public string CardBackImg { get; set; }

        /// <summary>
        /// 法人/经营者证件正面照（使用图片上传接口返回的image_id）
        /// </summary>
        [XmlElement("card_front_img")]
        public string CardFrontImg { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 证件类型，枚举值：中国大陆居民-身份证(RESIDENT)、其他国家或地区居民-护照(PASSPORT)、中国港澳居民-来往内地通行证(PASSPORT_HK_MO)、中国台湾居民-来往大陆通行证(PASSPORT_TWN)、港澳居民居住证（RESIDENCE_PERMIT_HM）、台湾居民居住证（RESIDENCE_PERMIT_TW）、外国人永久居住证（PERMANENT_RESIDENCE_FOREIGNER）。个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关、小微商户仅支持身份证类型。
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 证件生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 证件过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 经营者/法人是否为受益人
        /// </summary>
        [XmlElement("is_benefit_person")]
        public bool IsBenefitPerson { get; set; }

        /// <summary>
        /// 证件持有人类型： - 法人  LEGAL_PERSON - 经办人  AGENT_PERSON 主体类型为政府机关、事业单位时选传： （1）若上传的是法人证件，则不需要上传该字段。 （2）若因特殊情况，无法提供法人证件时，可上传经办人。 主体类型为企业、个体户、社会组织、小微商户时，默认为经营者/法人，不需要上传该字段。
        /// </summary>
        [XmlElement("legal_type")]
        public string LegalType { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }
    }
}
