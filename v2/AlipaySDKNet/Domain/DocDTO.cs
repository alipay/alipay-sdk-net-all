using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DocDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DocDTO : AopObject
    {
        /// <summary>
        /// 城市编码，支持传多个（逗号分隔）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 政策文件id
        /// </summary>
        [XmlElement("doc_file_id")]
        public string DocFileId { get; set; }

        /// <summary>
        /// 描述文件基本信息的标题
        /// </summary>
        [XmlElement("doc_title")]
        public string DocTitle { get; set; }

        /// <summary>
        /// 表示文件类型
        /// </summary>
        [XmlElement("doc_type")]
        public string DocType { get; set; }

        /// <summary>
        /// 政策文档的唯一id
        /// </summary>
        [XmlElement("out_doc_id")]
        public string OutDocId { get; set; }

        /// <summary>
        /// 语料运行状态
        /// </summary>
        [XmlElement("run_status")]
        public string RunStatus { get; set; }
    }
}
