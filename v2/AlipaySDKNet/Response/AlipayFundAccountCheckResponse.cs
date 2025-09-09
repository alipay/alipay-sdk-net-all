using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountCheckResponse.
    /// </summary>
    public class AlipayFundAccountCheckResponse : AopResponse
    {
        /// <summary>
        /// 校验结果 Y：一致 N：不一致
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }
    }
}
