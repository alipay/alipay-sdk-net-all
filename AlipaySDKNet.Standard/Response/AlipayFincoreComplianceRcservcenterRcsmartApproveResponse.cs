using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartApproveResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcservcenterRcsmartApproveResponse : AopResponse
    {
        /// <summary>
        /// 解语花统一返回对象
        /// </summary>
        [XmlElement("rc_smart_response")]
        public RcSmartResponse RcSmartResponse { get; set; }
    }
}
