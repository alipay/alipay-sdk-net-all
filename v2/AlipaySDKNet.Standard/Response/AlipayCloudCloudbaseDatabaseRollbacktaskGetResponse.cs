using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseRollbacktaskGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseRollbacktaskGetResponse : AopResponse
    {
        /// <summary>
        /// 归档时间
        /// </summary>
        [XmlElement("archive_time")]
        public string ArchiveTime { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 回档任务状态  - SUCCESS  - FAILED  - DOING
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
