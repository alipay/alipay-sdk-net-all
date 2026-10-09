using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndrbeneficiaryQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenIndrbeneficiaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 收款方信息(结果为success才会返回)
        /// </summary>
        [XmlElement("beneficiary_list")]
        public IndrISVBeneficiaryDTO BeneficiaryList { get; set; }

        /// <summary>
        /// 验证结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
