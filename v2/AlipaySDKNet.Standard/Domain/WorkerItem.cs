using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkerItem Data Structure.
    /// </summary>
    [Serializable]
    public class WorkerItem : AopObject
    {
        /// <summary>
        /// 头像URL
        /// </summary>
        [XmlElement("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否展示：0-不展示 1-展示，默认1
        /// </summary>
        [XmlElement("display")]
        public string Display { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 关联IVR流程code(对应任务 taskIVRCode/transferCode)。部分数字人未配置 chat 模块时该字段为 null
        /// </summary>
        [XmlElement("ivr_code")]
        public string IvrCode { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 数字员工启用标识：0-已停用 1-启用中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 数字员工类型，默认aiworker
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 版本类型：simple=极致版，空值=不过滤，synthetical=旧版数据
        /// </summary>
        [XmlElement("version_type")]
        public string VersionType { get; set; }

        /// <summary>
        /// 数字人标识
        /// </summary>
        [XmlElement("worker_code")]
        public string WorkerCode { get; set; }
    }
}
