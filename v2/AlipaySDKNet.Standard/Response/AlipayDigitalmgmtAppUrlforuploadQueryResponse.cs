using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtAppUrlforuploadQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtAppUrlforuploadQueryResponse : AopResponse
    {
        /// <summary>
        /// 无
        /// </summary>
        [XmlElement("url_for_upload_file")]
        public string UrlForUploadFile { get; set; }
    }
}
