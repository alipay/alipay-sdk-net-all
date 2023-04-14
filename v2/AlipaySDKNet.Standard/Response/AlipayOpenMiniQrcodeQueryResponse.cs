using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniQrcodeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 规则路由数据列表
        /// </summary>
        [XmlArray("qr_code_route_groups")]
        [XmlArrayItem("qr_code_route_group")]
        public List<QrCodeRouteGroup> QrCodeRouteGroups { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }
    }
}
