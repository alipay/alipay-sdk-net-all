using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝商品ID列表
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// isv内部产生商品ID
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }
    }
}
