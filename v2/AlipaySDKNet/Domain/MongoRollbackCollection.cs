using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MongoRollbackCollection Data Structure.
    /// </summary>
    [Serializable]
    public class MongoRollbackCollection : AopObject
    {
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
    }
}
