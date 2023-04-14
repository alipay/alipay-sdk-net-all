using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectionFileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CollectionFileDTO : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("file_addr")]
        public string FileAddr { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件是否需要保存
        /// </summary>
        [XmlElement("file_should_save")]
        public bool FileShouldSave { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 上传人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("prove_type")]
        public string ProveType { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }
    }
}
