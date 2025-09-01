using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAuthorizationApplyResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionAuthorizationApplyResponse : AopResponse
    {
        /// <summary>
        /// 外部申请请求流水号，外部请求的唯一标识
        /// </summary>
        [XmlElement("apply_request_no")]
        public string ApplyRequestNo { get; set; }

        /// <summary>
        /// 签约地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
