using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeOrgroleQueryResponse.
    /// </summary>
    public class AlipayBossBaseAntauthorizeOrgroleQueryResponse : AopResponse
    {
        /// <summary>
        /// 组织节点上人员信息
        /// </summary>
        [XmlElement("org_role")]
        public OrgRoleDTO OrgRole { get; set; }
    }
}
