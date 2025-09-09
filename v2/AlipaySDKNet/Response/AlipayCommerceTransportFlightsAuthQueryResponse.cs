using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportFlightsAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportFlightsAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权状态。 限定取值： authed：已授权、unauthed：未授权、revoked：取消授权
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 外部业务号，唯一标志本次请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
