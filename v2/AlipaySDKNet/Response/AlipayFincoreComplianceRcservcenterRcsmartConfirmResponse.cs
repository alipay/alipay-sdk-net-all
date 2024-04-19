using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartConfirmResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservcenterRcsmartConfirmResponse : AopResponse
    {
        /// <summary>
        /// 工单维度打标返回值
        /// </summary>
        [XmlElement("rc_smart_response")]
        public RcSmartResponse RcSmartResponse { get; set; }
    }
}
