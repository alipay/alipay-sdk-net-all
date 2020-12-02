using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandUploadResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片上传成功后的地址
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }
    }
}
