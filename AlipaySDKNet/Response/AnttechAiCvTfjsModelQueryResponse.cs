using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelQueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelQueryResponse : AopResponse
    {
        /// <summary>
        /// tfjs端模型bin文件下载url
        /// </summary>
        [XmlElement("bin_url")]
        public string BinUrl { get; set; }

        /// <summary>
        /// tfjs端模型json文件下载url
        /// </summary>
        [XmlElement("model_json_url")]
        public string ModelJsonUrl { get; set; }
    }
}
