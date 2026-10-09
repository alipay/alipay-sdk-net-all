using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MemberDTO : AopObject
    {
        /// <summary>
        /// 实体角色id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 会员名
        /// </summary>
        [XmlElement("unique_name")]
        public string UniqueName { get; set; }
    }
}
