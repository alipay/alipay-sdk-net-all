using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOpenCheckResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOpenCheckResponse : AopResponse
    {
        /// <summary>
        /// 预校验是否通过
        /// </summary>
        [XmlElement("check_result")]
        public bool CheckResult { get; set; }

        /// <summary>
        /// 预校验失败的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }
    }
}
