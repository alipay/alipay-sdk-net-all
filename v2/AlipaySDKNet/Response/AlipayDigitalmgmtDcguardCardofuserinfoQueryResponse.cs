using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtDcguardCardofuserinfoQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtDcguardCardofuserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 工卡查询人员结果
        /// </summary>
        [XmlElement("result")]
        public UserIdentificationDTO Result { get; set; }
    }
}
