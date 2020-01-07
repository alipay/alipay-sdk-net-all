using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanOfflineResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanOfflineResponse : AopResponse
    {
        /// <summary>
        /// 广告计划下线结果 + 根据广告计划id操作计划下线，下线成功返回true，否则返回false
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
