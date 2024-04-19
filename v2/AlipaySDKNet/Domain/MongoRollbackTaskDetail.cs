using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MongoRollbackTaskDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MongoRollbackTaskDetail : AopObject
    {
        /// <summary>
        /// 回档任务明细id
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 任务执行进度
        /// </summary>
        [XmlElement("process")]
        public string Process { get; set; }

        /// <summary>
        /// 回档后集合名称
        /// </summary>
        [XmlElement("rollback_collection_name")]
        public string RollbackCollectionName { get; set; }

        /// <summary>
        /// 回档集合名称
        /// </summary>
        [XmlElement("source_collection_name")]
        public string SourceCollectionName { get; set; }

        /// <summary>
        /// 回档任务明细状态  - SUCCESS  - FAILED  - DOING
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
