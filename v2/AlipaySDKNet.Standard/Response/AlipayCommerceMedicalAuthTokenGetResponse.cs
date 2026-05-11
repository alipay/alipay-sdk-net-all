using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthTokenGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("auth_result")]
        public AuthResult AuthResult { get; set; }
    }
}
