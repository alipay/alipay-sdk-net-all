using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnercontentSignResponse.
    /// </summary>
    public class AlipayOpenMiniInnercontentSignResponse : AopResponse
    {
        /// <summary>
        /// 加签后cert.json内容
        /// </summary>
        [XmlElement("cert_json")]
        public string CertJson { get; set; }

        /// <summary>
        /// 逐项rsa加签内容
        /// </summary>
        [XmlArray("sign_content_list")]
        [XmlArrayItem("sign_content_body_response")]
        public List<SignContentBodyResponse> SignContentList { get; set; }

        /// <summary>
        /// 加签后sign.json内容
        /// </summary>
        [XmlElement("sign_json")]
        public string SignJson { get; set; }
    }
}
