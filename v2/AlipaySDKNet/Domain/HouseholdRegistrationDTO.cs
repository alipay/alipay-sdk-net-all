using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HouseholdRegistrationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HouseholdRegistrationDTO : AopObject
    {
        /// <summary>
        /// 现户籍登记住址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 出生地
        /// </summary>
        [XmlElement("birth_place")]
        public string BirthPlace { get; set; }

        /// <summary>
        /// 血型
        /// </summary>
        [XmlElement("blood_desc")]
        public string BloodDesc { get; set; }

        /// <summary>
        /// 职业类别
        /// </summary>
        [XmlElement("career")]
        public string Career { get; set; }

        /// <summary>
        /// 本市其他住址
        /// </summary>
        [XmlElement("city_other_addresses")]
        public string CityOtherAddresses { get; set; }

        /// <summary>
        /// 承办人签章
        /// </summary>
        [XmlElement("contractor")]
        public string Contractor { get; set; }

        /// <summary>
        /// 签发日期
        /// </summary>
        [XmlElement("data_issue")]
        public string DataIssue { get; set; }

        /// <summary>
        /// 文化程度
        /// </summary>
        [XmlElement("degree_of_education")]
        public string DegreeOfEducation { get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        [XmlElement("former_name")]
        public string FormerName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("household_number")]
        public string HouseholdNumber { get; set; }

        /// <summary>
        /// 户别类型
        /// </summary>
        [XmlElement("household_type")]
        public string HouseholdType { get; set; }

        /// <summary>
        /// 公民身份证号码
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        [XmlElement("marital_desc")]
        public string MaritalDesc { get; set; }

        /// <summary>
        /// 兵役状况
        /// </summary>
        [XmlElement("military_desc")]
        public string MilitaryDesc { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [XmlElement("native_place")]
        public string NativePlace { get; set; }

        /// <summary>
        /// 人号
        /// </summary>
        [XmlElement("person_id")]
        public string PersonId { get; set; }

        /// <summary>
        /// 户口簿打印日期
        /// </summary>
        [XmlElement("print_date")]
        public string PrintDate { get; set; }

        /// <summary>
        /// 户籍登记日期
        /// </summary>
        [XmlElement("registration_date")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// 与户主关系
        /// </summary>
        [XmlElement("relationship_desc")]
        public string RelationshipDesc { get; set; }

        /// <summary>
        /// 宗教信息
        /// </summary>
        [XmlElement("religion")]
        public string Religion { get; set; }

        /// <summary>
        /// 工作单位或服务机构
        /// </summary>
        [XmlElement("service_location")]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 迁入本址信息
        /// </summary>
        [XmlElement("when_and_from_moved_address")]
        public string WhenAndFromMovedAddress { get; set; }

        /// <summary>
        /// 迁入本市信息
        /// </summary>
        [XmlElement("when_and_from_moved_city")]
        public string WhenAndFromMovedCity { get; set; }
    }
}
