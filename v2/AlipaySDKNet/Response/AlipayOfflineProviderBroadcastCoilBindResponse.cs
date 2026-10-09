using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastCoilBindResponse.
    /// </summary>
    public class AlipayOfflineProviderBroadcastCoilBindResponse : AopResponse
    {
        /// <summary>
        /// 绑定操作是否成功
        /// </summary>
        [XmlElement("bind_result")]
        public bool BindResult { get; set; }

        /// <summary>
        /// 本次绑定生效的线圈碰触达地址
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }

        /// <summary>
        /// 本次绑定的碰线圈ID
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
