using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberArchiveOpenApiInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MemberArchiveOpenApiInfoDTO : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 档案编号
        /// </summary>
        [XmlElement("archive_no")]
        public string ArchiveNo { get; set; }

        /// <summary>
        /// 头像链接
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 脱敏身份证号
        /// </summary>
        [XmlElement("desensitization_id_number")]
        public string DesensitizationIdNumber { get; set; }

        /// <summary>
        /// 脱敏手机号
        /// </summary>
        [XmlElement("desensitization_phone")]
        public string DesensitizationPhone { get; set; }

        /// <summary>
        /// 脱敏姓名
        /// </summary>
        [XmlElement("desensitization_username")]
        public string DesensitizationUsername { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 枚举值： 10-大陆身份证，12-港澳台身份证，20-护照；
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 枚举值： SELF:SELF SPOUSE:SPOUSE PARENT:PARENT CHILDREN:CHILDREN FRIEND:FRIEND OTHER:OTHER
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
