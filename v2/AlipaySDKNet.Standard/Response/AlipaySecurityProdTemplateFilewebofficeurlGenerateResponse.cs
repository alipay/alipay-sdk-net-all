using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateFilewebofficeurlGenerateResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateFilewebofficeurlGenerateResponse : AopResponse
    {
        /// <summary>
        /// 文档编辑ak
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 刷新用的oss文件编辑token
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 文档编辑url
        /// </summary>
        [XmlElement("weboffice_url")]
        public string WebofficeUrl { get; set; }
    }
}
