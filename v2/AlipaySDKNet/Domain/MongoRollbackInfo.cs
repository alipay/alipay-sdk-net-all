using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MongoRollbackInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MongoRollbackInfo : AopObject
    {
        /// <summary>
        /// 归档时间
        /// </summary>
        [XmlElement("archive_time")]
        public string ArchiveTime { get; set; }

        /// <summary>
        /// 可回档集合列表
        /// </summary>
        [XmlArray("rollback_collections")]
        [XmlArrayItem("mongo_collection_info")]
        public List<MongoCollectionInfo> RollbackCollections { get; set; }
    }
}
