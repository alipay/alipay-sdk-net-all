using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoFilePathQueryResponse.
    /// </summary>
    public class AlipayEcoFilePathQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件Id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件直传地址, 可以重复使用，但是只能传一样的文件，有效期一小时
        /// </summary>
        [XmlElement("upload_url")]
        public string UploadUrl { get; set; }
    }
}
