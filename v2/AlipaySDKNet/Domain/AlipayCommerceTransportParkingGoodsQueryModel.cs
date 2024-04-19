using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingGoodsQueryModel : AopObject
    {
        /// <summary>
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// isv内部产生商品ID
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 支付宝返回停车场ID
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
