using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageDirectoryCreateResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageDirectoryCreateResponse : AopResponse
    {
        /// <summary>
        /// 文件夹的File ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
