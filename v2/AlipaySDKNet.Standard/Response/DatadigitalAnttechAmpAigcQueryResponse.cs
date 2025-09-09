using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechAmpAigcQueryResponse.
    /// </summary>
    public class DatadigitalAnttechAmpAigcQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 生成状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
