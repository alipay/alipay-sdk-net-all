using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleBtoborderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportCarsaleBtoborderSyncModel : AopObject
    {
        /// <summary>
        /// 城市编码，买家城市编码
        /// </summary>
        [XmlElement("buy_city_code")]
        public string BuyCityCode { get; set; }

        /// <summary>
        /// 买家手机号
        /// </summary>
        [XmlElement("buy_mobile_no")]
        public string BuyMobileNo { get; set; }

        /// <summary>
        /// 车源城市编码
        /// </summary>
        [XmlElement("car_city_code")]
        public string CarCityCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额;单位分
        /// </summary>
        [XmlElement("order_amount")]
        public long OrderAmount { get; set; }

        /// <summary>
        /// 车生活orderNo， 修改订单时候， 必传。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 已收金额；单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("second_pid")]
        public string SecondPid { get; set; }

        /// <summary>
        /// 卖家手机号
        /// </summary>
        [XmlElement("sell_mobile_no")]
        public string SellMobileNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("sell_open_id")]
        public string SellOpenId { get; set; }

        /// <summary>
        /// 卖方uid, 支付宝uid
        /// </summary>
        [XmlElement("sell_user_id")]
        public string SellUserId { get; set; }

        /// <summary>
        /// 待收金额；单位分
        /// </summary>
        [XmlElement("unpay_amount")]
        public long UnpayAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [XmlElement("vehicle_info")]
        public CarSaleVehicleInfoDTO VehicleInfo { get; set; }

        /// <summary>
        /// vin码
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
