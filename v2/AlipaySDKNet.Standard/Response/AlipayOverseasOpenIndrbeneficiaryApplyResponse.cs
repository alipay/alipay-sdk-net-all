using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndrbeneficiaryApplyResponse.
    /// </summary>
    public class AlipayOverseasOpenIndrbeneficiaryApplyResponse : AopResponse
    {
        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("beneficiary_id")]
        public string BeneficiaryId { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
