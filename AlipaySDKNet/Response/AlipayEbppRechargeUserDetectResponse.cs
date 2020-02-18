using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRechargeUserDetectResponse.
    /// </summary>
    public class AlipayEbppRechargeUserDetectResponse : AopResponse
    {
        /// <summary>
        /// 是否是合法用户
        /// </summary>
        [XmlElement("check_result")]
        public bool CheckResult { get; set; }
    }
}
