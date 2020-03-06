using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelQueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelQueryResponse : AopResponse
    {
        /// <summary>
        /// 已废弃
        /// </summary>
        [XmlElement("bin_url")]
        public string BinUrl { get; set; }

        /// <summary>
        /// 模型bin文件的下载地址
        /// </summary>
        [XmlArray("bin_urls")]
        [XmlArrayItem("string")]
        public List<string> BinUrls { get; set; }

        /// <summary>
        /// tfjs端模型json文件下载url
        /// </summary>
        [XmlElement("model_json_url")]
        public string ModelJsonUrl { get; set; }
    }
}
