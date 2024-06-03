using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthorizeQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthorizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 一码付签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
