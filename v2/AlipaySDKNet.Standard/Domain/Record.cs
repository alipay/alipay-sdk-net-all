using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Record Data Structure.
    /// </summary>
    [Serializable]
    public class Record : AopObject
    {
        /// <summary>
        /// 阿福用户openid
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 数据唯一标识（即保存时写入的 dataId，非数据库主键）
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 关键字段，数据来源机构码，映射 health_archive_org_config 表的 org_code 字段（详见 关键字段说明）。撤销保存时与 userId、dataId、dataType 组合定位需删除的记录，值需与保存时写入的 data_source 一致（如 XXJ）
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 路由字段，报告类型标识，决定查询和删除哪张表。可选值参见 dataType 路由说明
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
