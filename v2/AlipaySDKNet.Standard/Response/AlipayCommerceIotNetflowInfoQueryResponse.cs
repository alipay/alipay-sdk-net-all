using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotNetflowInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceIotNetflowInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 流量充值记录信息
        /// </summary>
        [XmlElement("net_flow_device_offer_info_response")]
        public NetFlowDeviceOfferInfoResponse NetFlowDeviceOfferInfoResponse { get; set; }
    }
}
