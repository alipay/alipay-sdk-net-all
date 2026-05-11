using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthenticationTokenVerifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthenticationTokenVerifyResponse : AopResponse
    {
        /// <summary>
        /// 响应结果数据
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
