using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusCheckinDownloadResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusCheckinDownloadResponse : AopResponse
    {
        /// <summary>
        /// file_path
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }
    }
}
