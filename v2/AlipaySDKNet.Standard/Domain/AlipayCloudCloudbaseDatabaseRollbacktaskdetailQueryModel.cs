using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseRollbacktaskdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseDatabaseRollbacktaskdetailQueryModel : AopObject
    {
        /// <summary>
        /// 归档时间
        /// </summary>
        [XmlElement("archive_time")]
        public string ArchiveTime { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 是否逆序
        /// </summary>
        [XmlElement("desc")]
        public bool Desc { get; set; }

        /// <summary>
        /// 回档任务id
        /// </summary>
        [XmlElement("history_id")]
        public string HistoryId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }
    }
}
