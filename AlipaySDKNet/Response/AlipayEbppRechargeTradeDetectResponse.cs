using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRechargeTradeDetectResponse.
    /// </summary>
    public class AlipayEbppRechargeTradeDetectResponse : AopResponse
    {
        /// <summary>
        /// 手机号绑定的userId是否有充值记录。
        /// </summary>
        [XmlElement("check_result")]
        public bool CheckResult { get; set; }
    }
}
