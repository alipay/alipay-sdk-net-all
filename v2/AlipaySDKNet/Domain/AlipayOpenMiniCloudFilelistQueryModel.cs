using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudFilelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudFilelistQueryModel : AopObject
    {
        /// <summary>
        /// 云环境ID,在云托管平台获取
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 上次列表查询返回的文件游标索引
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询数量，默认为100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 文件路径,必须以/开头，根目录/
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 模糊搜索的前缀
        /// </summary>
        [XmlElement("prefix")]
        public string Prefix { get; set; }
    }
}
