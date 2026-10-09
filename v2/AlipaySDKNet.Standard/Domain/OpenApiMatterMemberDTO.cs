using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiMatterMemberDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiMatterMemberDTO : AopObject
    {
        /// <summary>
        /// 事项编码
        /// </summary>
        [XmlElement("matter_code")]
        public string MatterCode { get; set; }

        /// <summary>
        /// 事项类型
        /// </summary>
        [XmlElement("matter_type")]
        public string MatterType { get; set; }

        /// <summary>
        /// 参与人工号
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 人员角色
        /// </summary>
        [XmlElement("member_role_enum")]
        public string MemberRoleEnum { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 事项子类型
        /// </summary>
        [XmlElement("sub_matter_type")]
        public string SubMatterType { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
