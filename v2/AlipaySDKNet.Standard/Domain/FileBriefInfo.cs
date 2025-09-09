using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileBriefInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FileBriefInfo : AopObject
    {
        /// <summary>
        /// 文件id，该字段唯一表示一份文件，并在上传文件时候由问答系统生成。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 上传的文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 该字段描述了文件当前状态，包括embedding、删除等状态，根据该字段可以判断文件是否可以用于智能问答。
        /// </summary>
        [XmlElement("file_status")]
        public string FileStatus { get; set; }

        /// <summary>
        /// 文件创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 文件修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
