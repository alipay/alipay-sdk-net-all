using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRoleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRoleModifyModel : AopObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID），不传默认使用租户id
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 描述信息
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
        /// 最后修改人id
        /// </summary>
        [XmlElement("updater_id")]
        public string UpdaterId { get; set; }
    }
}
