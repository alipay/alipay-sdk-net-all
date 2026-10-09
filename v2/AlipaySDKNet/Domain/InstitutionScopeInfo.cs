using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstitutionScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstitutionScopeInfo : AopObject
    {
        /// <summary>
        /// 制度适用范围，支持配置全员、指定员工和指定部门
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 适用范围归属id列表
        /// </summary>
        [XmlArray("owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerIdList { get; set; }

        /// <summary>
        /// 员工id类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }
    }
}
