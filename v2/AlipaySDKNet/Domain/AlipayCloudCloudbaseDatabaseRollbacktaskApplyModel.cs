using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseRollbacktaskApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseDatabaseRollbacktaskApplyModel : AopObject
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
        /// 归档集合列表
        /// </summary>
        [XmlArray("rollback_collections")]
        [XmlArrayItem("mongo_rollback_collection")]
        public List<MongoRollbackCollection> RollbackCollections { get; set; }
    }
}
