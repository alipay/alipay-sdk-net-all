using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModifyScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ModifyScopeInfo : AopObject
    {
        /// <summary>
        /// 制度的适用范围类型
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 增加的归属id列表
        /// </summary>
        [XmlArray("add_owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddOwnerIdList { get; set; }

        /// <summary>
        /// 删除归属id列表
        /// </summary>
        [XmlArray("delete_owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeleteOwnerIdList { get; set; }

        /// <summary>
        /// 归属id类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }
    }
}
