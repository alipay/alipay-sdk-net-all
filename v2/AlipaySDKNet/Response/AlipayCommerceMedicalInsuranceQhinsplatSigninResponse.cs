using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceQhinsplatSigninResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceQhinsplatSigninResponse : AopResponse
    {
        /// <summary>
        /// 响应出参
        /// </summary>
        [XmlElement("response_str")]
        public string ResponseStr { get; set; }
    }
}
