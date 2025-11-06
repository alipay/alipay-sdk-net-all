using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBookPatientQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalBookPatientQueryResponse : AopResponse
    {
        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 身份证类型
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 患者id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 关系
        /// </summary>
        [XmlElement("relationship")]
        public string Relationship { get; set; }
    }
}
