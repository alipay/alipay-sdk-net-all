using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoAttachmentUploadResponse.
    /// </summary>
    public class AntMerchantExpandEcoAttachmentUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件上传成功返回的osskey
        /// </summary>
        [XmlElement("oss_key")]
        public string OssKey { get; set; }
    }
}
