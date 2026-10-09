using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetPictureCheckavailableResponse.
    /// </summary>
    public class AlipayCommercePetPictureCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// 核验通过的文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
