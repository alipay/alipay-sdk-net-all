using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Role Data Structure.
    /// </summary>
    [Serializable]
    public class Role : AopObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 角色描述描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 角色关联额功能点id
        /// </summary>
        [XmlArray("function_ids")]
        [XmlArrayItem("string")]
        public List<string> FunctionIds { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 最后修改人id
        /// </summary>
        [XmlElement("updater_id")]
        public string UpdaterId { get; set; }
    }
}
