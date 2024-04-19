using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVPoboBuyerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVPoboBuyerInfo : AopObject
    {
        /// <summary>
        /// academic_year+留学缴费
        /// </summary>
        [XmlElement("academic_year")]
        public string AcademicYear { get; set; }

        /// <summary>
        /// 生日：yyyy-MM-DD，示例值加了双引号
        /// </summary>
        [XmlElement("date_of_birth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// email+留学缴费
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户名字
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 用户英文名或者拼音名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 用户姓氏
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// phone_area_code+留学缴费
        /// </summary>
        [XmlElement("phone_area_code")]
        public string PhoneAreaCode { get; set; }

        /// <summary>
        /// phone_number+留学缴费
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 学号+留学缴费
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }
    }
}
