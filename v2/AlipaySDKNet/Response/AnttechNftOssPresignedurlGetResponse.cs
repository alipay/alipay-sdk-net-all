using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftOssPresignedurlGetResponse.
    /// </summary>
    public class AnttechNftOssPresignedurlGetResponse : AopResponse
    {
        /// <summary>
        /// oss回调头，包含回调方法体
        /// </summary>
        [XmlElement("oss_header_callback")]
        public string OssHeaderCallback { get; set; }

        /// <summary>
        /// 返回给第三方用于上传文件的预签名url。
        /// </summary>
        [XmlElement("presigned_url")]
        public string PresignedUrl { get; set; }
    }
}
