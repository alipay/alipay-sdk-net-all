using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeOrgroleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseAntauthorizeOrgroleQueryModel : AopObject
    {
        /// <summary>
        /// 场景用户查询对象-组织视角
        /// </summary>
        [XmlElement("query")]
        public OrgRoleQuery Query { get; set; }

        /// <summary>
        /// 接口查询信息，包含调用接口的系统、人的域账号、调用类型
        /// </summary>
        [XmlElement("query_info")]
        public QueryInfo QueryInfo { get; set; }
    }
}
