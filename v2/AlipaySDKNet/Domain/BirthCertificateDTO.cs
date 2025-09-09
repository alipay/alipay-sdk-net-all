using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BirthCertificateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BirthCertificateDTO : AopObject
    {
        /// <summary>
        /// 出生孕周
        /// </summary>
        [XmlElement("birth_gestational_weeks")]
        public string BirthGestationalWeeks { get; set; }

        /// <summary>
        /// 出生身长
        /// </summary>
        [XmlElement("birth_length")]
        public string BirthLength { get; set; }

        /// <summary>
        /// 接生机构全称
        /// </summary>
        [XmlElement("birth_medical_institution")]
        public string BirthMedicalInstitution { get; set; }

        /// <summary>
        /// 出生时间
        /// </summary>
        [XmlElement("birth_time")]
        public string BirthTime { get; set; }

        /// <summary>
        /// 出生体重
        /// </summary>
        [XmlElement("birth_weight")]
        public string BirthWeight { get; set; }

        /// <summary>
        /// 签发日期
        /// </summary>
        [XmlElement("date_issue")]
        public string DateIssue { get; set; }

        /// <summary>
        /// 父亲住址
        /// </summary>
        [XmlElement("father_address")]
        public string FatherAddress { get; set; }

        /// <summary>
        /// 父亲年龄
        /// </summary>
        [XmlElement("father_age")]
        public string FatherAge { get; set; }

        /// <summary>
        /// 父亲国籍
        /// </summary>
        [XmlElement("father_country")]
        public string FatherCountry { get; set; }

        /// <summary>
        /// 父亲身份证号
        /// </summary>
        [XmlElement("father_id_card")]
        public string FatherIdCard { get; set; }

        /// <summary>
        /// 父亲姓名
        /// </summary>
        [XmlElement("father_name")]
        public string FatherName { get; set; }

        /// <summary>
        /// 父亲民族
        /// </summary>
        [XmlElement("father_nationality")]
        public string FatherNationality { get; set; }

        /// <summary>
        /// 新生儿姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 母亲住址
        /// </summary>
        [XmlElement("mother_address")]
        public string MotherAddress { get; set; }

        /// <summary>
        /// 母亲年龄
        /// </summary>
        [XmlElement("mother_age")]
        public string MotherAge { get; set; }

        /// <summary>
        /// 母亲国籍
        /// </summary>
        [XmlElement("mother_country")]
        public string MotherCountry { get; set; }

        /// <summary>
        /// 母亲身份证号
        /// </summary>
        [XmlElement("mother_id_card")]
        public string MotherIdCard { get; set; }

        /// <summary>
        /// 母亲姓名
        /// </summary>
        [XmlElement("mother_name")]
        public string MotherName { get; set; }

        /// <summary>
        /// 母亲民族
        /// </summary>
        [XmlElement("mother_nationality")]
        public string MotherNationality { get; set; }

        /// <summary>
        /// 编号（唯一标识）
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 出生地
        /// </summary>
        [XmlElement("place_birth")]
        public string PlaceBirth { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }
    }
}
