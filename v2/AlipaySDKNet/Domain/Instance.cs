using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Instance Data Structure.
    /// </summary>
    [Serializable]
    public class Instance : AopObject
    {
        /// <summary>
        /// ?创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 部门描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 租户实例（数据权限）名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 租户实例（数据权限）状态，所有可能的状态如下：INIT（初始化）、STARTED（准备完成）、START_FAILED（准备失败）、STOPPING（停用中）、STOPPED（已停用）、RELEASING（释放中）、RELEASED（已释放）、RESUMING（重新启动）、MODIFING（修改规格中）、DELETED（已删除）。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

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
