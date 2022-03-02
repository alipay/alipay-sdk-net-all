using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgNodeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrgNodeDTO : AopObject
    {
        /// <summary>
        /// 节点code,如部门code,业务线code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
