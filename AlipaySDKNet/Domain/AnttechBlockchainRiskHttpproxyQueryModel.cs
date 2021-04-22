using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainRiskHttpproxyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainRiskHttpproxyQueryModel : AopObject
    {
        /// <summary>
        /// char set
        /// </summary>
        [XmlElement("char_set")]
        public string CharSet { get; set; }

        /// <summary>
        /// content type
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// http body参数
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// http请求头
        /// </summary>
        [XmlElement("headers")]
        public string Headers { get; set; }

        /// <summary>
        /// http 方法
        /// </summary>
        [XmlElement("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// url参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 请求url地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
