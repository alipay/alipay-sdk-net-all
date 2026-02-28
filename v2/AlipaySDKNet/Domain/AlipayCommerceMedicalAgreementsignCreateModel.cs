using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAgreementsignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAgreementsignCreateModel : AopObject
    {
        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("agreement_signing_time")]
        public string AgreementSigningTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("agreement_template_list")]
        [XmlArrayItem("agreement_template")]
        public List<AgreementTemplate> AgreementTemplateList { get; set; }

        /// <summary>
        /// 应用编码
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 签约人支付宝userid(2088)
        /// </summary>
        [XmlElement("signing_alipay_user_id")]
        public string SigningAlipayUserId { get; set; }

        /// <summary>
        /// 签约人身份证
        /// </summary>
        [XmlElement("signing_cert_no")]
        public string SigningCertNo { get; set; }

        /// <summary>
        /// 签约人姓名
        /// </summary>
        [XmlElement("signing_name")]
        public string SigningName { get; set; }

        /// <summary>
        /// 签约人手机号
        /// </summary>
        [XmlElement("signing_phone_no")]
        public string SigningPhoneNo { get; set; }
    }
}
