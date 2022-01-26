using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniQrcodeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 规则路由数据
        /// </summary>
        [XmlElement("qr_code_route_groups")]
        public QrCodeRouteGroup QrCodeRouteGroups { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }
    }
}
