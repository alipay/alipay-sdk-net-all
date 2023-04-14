using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateXuexinIdentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateXuexinIdentityQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型， IDENTITY_CARD("IDENTITY_CARD", "1", "身份证")，PASSPORT("PASSPORT", "A", "护照")，目前只支持身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 教育层次 SPECIALTY("专科", "0"),  UNDERGRADUATE("本科", "1"),  MASTER("硕士", "2"),  DOCTOR("博士", "3"),  SECOND_DEGREE("第二学士学位", "4")
        /// </summary>
        [XmlElement("education_level")]
        public string EducationLevel { get; set; }

        /// <summary>
        /// 入学日期，学信网能力变更，目前无法交易入学时间准确性
        /// </summary>
        [XmlElement("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
