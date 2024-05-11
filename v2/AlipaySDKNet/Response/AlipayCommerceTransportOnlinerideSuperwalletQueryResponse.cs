using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOnlinerideSuperwalletQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOnlinerideSuperwalletQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的数据
        /// </summary>
        [XmlElement("data")]
        public OnlineRideSuperWalletData Data { get; set; }
    }
}
