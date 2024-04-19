using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFamilyShareAdmittancePreconsultResponse.
    /// </summary>
    public class AlipayUserFamilyShareAdmittancePreconsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admittance")]
        public bool Admittance { get; set; }

        /// <summary>
        /// 不可准入的原因
        /// </summary>
        [XmlElement("unadmitted_reason")]
        public string UnadmittedReason { get; set; }
    }
}
