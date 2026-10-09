using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkerGetDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class WorkerGetDetailData : AopObject
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
        public long Display { get; set; }

        /// <summary>
        /// 创建时间
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
        public long Id { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否有效：0-无效 1-有效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 类型，默认aiworker
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("variables")]
        [XmlArrayItem("string")]
        public List<string> Variables { get; set; }

        /// <summary>
        /// 版本类型：simple=极致版，空=旧版数据
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
