using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDirectoryCreateResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteDirectoryCreateResponse : AopResponse
    {
        /// <summary>
        /// 文件夹ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
