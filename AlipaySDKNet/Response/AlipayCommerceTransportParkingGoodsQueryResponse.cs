using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("parking_goods_detail")]
        public ParkingGoodsDetail ParkingGoodsDetail { get; set; }
    }
}
