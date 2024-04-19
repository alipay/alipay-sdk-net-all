using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingGoodsOnlineModel : AopObject
    {
        /// <summary>
        /// 支付宝商品唯一ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 操作类型：put-上架，pull-下架
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
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
