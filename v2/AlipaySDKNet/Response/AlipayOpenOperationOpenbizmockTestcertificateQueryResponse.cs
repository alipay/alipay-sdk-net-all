using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestcertificateQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestcertificateQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("result_openid")]
        public string ResultOpenid { get; set; }
    }
}
