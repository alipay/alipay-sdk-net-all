using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerPointRefundResponse.
    /// </summary>
    public class ZhimaCustomerPointRefundResponse : AopResponse
    {
        /// <summary>
        /// 芝麻粒是否返还完成
        /// </summary>
        [XmlElement("refund_finished")]
        public bool RefundFinished { get; set; }
    }
}
