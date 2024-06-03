using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechAmpAigcApplyResponse.
    /// </summary>
    public class DatadigitalAnttechAmpAigcApplyResponse : AopResponse
    {
        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文件生成状态
        /// </summary>
        [XmlElement("other_data")]
        public string OtherData { get; set; }
    }
}
