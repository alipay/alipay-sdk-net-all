using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoCertifyResponse.
    /// </summary>
    public class AlipayOverseasRemitBeneficialinfoCertifyResponse : AopResponse
    {
        /// <summary>
        /// 是否有默认收款卡号
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 验证是否通过
        /// </summary>
        [XmlElement("is_pass")]
        public bool IsPass { get; set; }
    }
}
