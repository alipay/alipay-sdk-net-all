using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalCardInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalCardInfoList : AopObject
    {
        /// <summary>
        /// 亲属医保电子凭证卡Id（即ec_auth_code）
        /// </summary>
        [XmlElement("family_medical_card_id")]
        public string FamilyMedicalCardId { get; set; }

        /// <summary>
        /// 亲属的医保电子凭证渠道用户Id。当传入的证件信息对应的用户于当前登录用户在支付宝渠道存在亲情账户绑定关系时返回
        /// </summary>
        [XmlElement("family_user_id")]
        public string FamilyUserId { get; set; }

        /// <summary>
        /// 参保地列表
        /// </summary>
        [XmlElement("insured_cities")]
        public MedicalInsuredCityList InsuredCities { get; set; }

        /// <summary>
        /// 医保电子凭证参保状态
        /// </summary>
        [XmlElement("insured_status")]
        public string InsuredStatus { get; set; }

        /// <summary>
        /// 医保电子凭证授权码(机构卡Id)
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 绑卡激活状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
