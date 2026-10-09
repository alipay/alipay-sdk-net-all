using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateRoleInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateRoleInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }
    }
}
