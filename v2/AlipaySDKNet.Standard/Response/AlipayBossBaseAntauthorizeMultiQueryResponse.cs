using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeMultiQueryResponse.
    /// </summary>
    public class AlipayBossBaseAntauthorizeMultiQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的具体授权信息
        /// </summary>
        [XmlElement("auth_amount_info")]
        public OpenApiAuthAmountInfoDTO AuthAmountInfo { get; set; }
    }
}
