using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MatchedMemberDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MatchedMemberDTO : AopObject
    {
        /// <summary>
        /// 档案成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 档案成员名称
        /// </summary>
        [XmlElement("member_name")]
        public string MemberName { get; set; }

        /// <summary>
        /// 档案成员角色
        /// </summary>
        [XmlElement("member_role")]
        public string MemberRole { get; set; }
    }
}
