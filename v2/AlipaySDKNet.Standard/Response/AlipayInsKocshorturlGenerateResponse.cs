using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsKocshorturlGenerateResponse.
    /// </summary>
    public class AlipayInsKocshorturlGenerateResponse : AopResponse
    {
        /// <summary>
        /// 校验成功后，基于入参拼接完链接参数后经转换生成的短链接，在用户进入投保页后会被重定向为原始链接，并由我方前端做进一步解析
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }
    }
}
