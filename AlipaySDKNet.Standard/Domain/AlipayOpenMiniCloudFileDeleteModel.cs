using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudFileDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudFileDeleteModel : AopObject
    {
        /// <summary>
        /// 云环境ID,在云托管平台获取
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 文件名称列表
        /// </summary>
        [XmlArray("file_name_list")]
        [XmlArrayItem("string")]
        public List<string> FileNameList { get; set; }

        /// <summary>
        /// 文件路径,必须以/开头，根目录/
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
