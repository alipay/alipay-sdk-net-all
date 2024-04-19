using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectFiletaskConsultResponse.
    /// </summary>
    public class AlipayMerchantIndirectFiletaskConsultResponse : AopResponse
    {
        /// <summary>
        /// 下载文件时配合返回的file_url使用，用于用户请求鉴权。请求file_url时，需要在请求header中添加 x-mass-token=${auth_token}
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 文件下载地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文件任务处理结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
