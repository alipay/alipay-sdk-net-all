using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPrivacyCustomfileUploadResponse.
    /// </summary>
    public class AlipayOpenMiniPrivacyCustomfileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件上传成功后，返回文件地址，用于create接口调用时传入。
        /// </summary>
        [XmlElement("user_custom_file")]
        public string UserCustomFile { get; set; }
    }
}
