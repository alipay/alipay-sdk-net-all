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
        /// 内部使用 uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
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
        /// 文件列表游标索引，next_token为文件分页参数，在本接口的响应中获取，传入next_token以获取下一页数据
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页大小，默认为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 父级目录过滤参数，传入此参数表示查询所传目录下的文件列表
        /// </summary>
        [XmlElement("parent_directory")]
        public string ParentDirectory { get; set; }

        /// <summary>
        /// 按前缀进行模糊搜索
        /// </summary>
        [XmlElement("prefix")]
        public string Prefix { get; set; }
    }
}
