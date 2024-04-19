using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeRoleuserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseAntauthorizeRoleuserQueryModel : AopObject
    {
        /// <summary>
        /// 查询职能角色人员列表入参
        /// </summary>
        [XmlElement("query")]
        public OrgRoleInfoQuery Query { get; set; }

        /// <summary>
        /// 接口查询信息，包含调用接口的系统、人的域账号、调用类型
        /// </summary>
        [XmlElement("query_info")]
        public QueryInfo QueryInfo { get; set; }
    }
}
