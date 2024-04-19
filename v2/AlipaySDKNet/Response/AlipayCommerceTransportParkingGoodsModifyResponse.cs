using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝商品唯一ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }
    }
}
