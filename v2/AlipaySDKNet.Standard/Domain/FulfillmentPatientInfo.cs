using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentPatientInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentPatientInfo : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 疾病描述/主诉
        /// </summary>
        [XmlElement("disease_desc")]
        public string DiseaseDesc { get; set; }

        /// <summary>
        /// 0-男，1-女
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("mindful_male_flag")]
        public bool MindfulMaleFlag { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 与患者关系
        /// </summary>
        [XmlElement("patient_relation")]
        public string PatientRelation { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
