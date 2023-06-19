using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageFilelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageFilelistQueryModel : AopObject
    {
        /// <summary>
        /// 云托管环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 文件id列表
        /// </summary>
        [XmlArray("file_id_list")]
        [XmlArrayItem("string")]
        public List<string> FileIdList { get; set; }

        /// <summary>
        /// 文件列表游标索引
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页大小，默认为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 按前缀进行模糊搜索
        /// </summary>
        [XmlElement("prefix")]
        public string Prefix { get; set; }
    }
}
