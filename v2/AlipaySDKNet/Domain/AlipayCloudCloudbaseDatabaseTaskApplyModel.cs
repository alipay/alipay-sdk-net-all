using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseDatabaseTaskApplyModel : AopObject
    {
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
        /// 集合名称
        /// </summary>
        [XmlElement("collection_name")]
        public string CollectionName { get; set; }

        /// <summary>
        /// 数据库任务命令  - getUploadUrl  - import  - export  - getDownloadUrl  - backup  - restore
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }

        /// <summary>
        /// 导入文件冲突处理方式  - INSERT  - UPSERT
        /// </summary>
        [XmlElement("conflict_mode")]
        public string ConflictMode { get; set; }

        /// <summary>
        /// 导出字段列表
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("string")]
        public List<string> Fields { get; set; }

        /// <summary>
        /// 导入或导出文件格式
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 任务序号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 上传id
        /// </summary>
        [XmlElement("upload_id")]
        public string UploadId { get; set; }
    }
}
