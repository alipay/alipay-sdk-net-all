using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftFileUrlQueryResponse.
    /// </summary>
    public class AnttechNftFileUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 私有URL的token
        /// </summary>
        [XmlElement("file_token")]
        public string FileToken { get; set; }

        /// <summary>
        /// 资源URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
