using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIsvauthTokenCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalIsvauthTokenCheckResponse : AopResponse
    {
        /// <summary>
        /// 授权校验结果
        /// </summary>
        [XmlElement("isv_auth_result")]
        public IsvAuthResult IsvAuthResult { get; set; }
    }
}
