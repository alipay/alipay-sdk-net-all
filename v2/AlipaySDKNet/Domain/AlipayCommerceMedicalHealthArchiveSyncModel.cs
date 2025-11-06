using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthArchiveSyncModel : AopObject
    {
        /// <summary>
        /// 以Map形式返回具体内容
        /// </summary>
        [XmlElement("content_data")]
        public ContentData ContentData { get; set; }

        /// <summary>
        /// 数据来源机构编码
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 同步状态
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }

        /// <summary>
        /// 同步方式-同步类型 total：全量同步 additional：增量同步 daily：T+1同步
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 任务id，字段来源扁鹊授权接口
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
