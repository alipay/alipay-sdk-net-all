using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerPointPayResponse.
    /// </summary>
    public class ZhimaCustomerPointPayResponse : AopResponse
    {
        /// <summary>
        /// 芝麻粒是否扣减完成
        /// </summary>
        [XmlElement("pay_finished")]
        public bool PayFinished { get; set; }
    }
}
