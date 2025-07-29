using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPayPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPayPrecreateModel : AopObject
    {
        /// <summary>
        /// 互联互通充电枪（设备）ID，用于关联用户充电使用的充电站
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 充电站纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 充电站经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单类型：PNC（即插即充订单）、NORMAL（普通订单）
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 互联互通充电站编码
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 互联互通充电站名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
