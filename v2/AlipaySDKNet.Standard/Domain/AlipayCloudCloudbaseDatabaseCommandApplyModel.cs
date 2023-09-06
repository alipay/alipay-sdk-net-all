using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseCommandApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseDatabaseCommandApplyModel : AopObject
    {
        /// <summary>
        /// 数据库操作命令参数，JSON格式
        /// </summary>
        [XmlElement("args")]
        public string Args { get; set; }

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
        /// - listCollections - createCollection - dropCollection - renameCollection - statsCollection - listIndexes - createIndex - dropIndex - insertOneDocument - insertManyDocuments - replaceOneDocument - deleteOneDocument - deleteManyDocuments - deleteManyDocumentsByIds - updateOneDocument - updateManyDocuments - find - count
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }
    }
}
