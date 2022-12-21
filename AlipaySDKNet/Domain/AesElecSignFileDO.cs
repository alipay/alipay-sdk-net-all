using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AesElecSignFileDO Data Structure.
    /// </summary>
    [Serializable]
    public class AesElecSignFileDO : AopObject
    {
        /// <summary>
        /// 文件id，唯一关联签约人组件信息
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件oss存储key，存储法务中台oss
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型：签约文件SIGNING/非签约文件NOSIGNING
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 关联审批流程节点id
        /// </summary>
        [XmlElement("related_process_id")]
        public long RelatedProcessId { get; set; }

        /// <summary>
        /// 签约任务流水号
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }
    }
}
