using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarOutorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarOutorderSyncModel : AopObject
    {
        /// <summary>
        /// 车生活车型id
        /// </summary>
        [XmlElement("carlife_vehicle_id")]
        public string CarlifeVehicleId { get; set; }

        /// <summary>
        /// 还车门店名称
        /// </summary>
        [XmlElement("drop_off_store_name")]
        public string DropOffStoreName { get; set; }

        /// <summary>
        /// 还车时间，精确到分，日期格式yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("drop_off_time")]
        public string DropOffTime { get; set; }

        /// <summary>
        /// 车生活订单号，订单首次同步时不需要传，首次同步时通过响应参数获取订单号，后续同步时需带上订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 状态机与车生活订单同步的状态机保持一致，详情见 https://adccloud.yuque.com/adccloud/aqkbzc/bg8fiw#BE7wh
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部三方服务商的租车订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("out_order_time")]
        public string OutOrderTime { get; set; }

        /// <summary>
        /// 取车门店名称
        /// </summary>
        [XmlElement("pick_up_store_name")]
        public string PickUpStoreName { get; set; }

        /// <summary>
        /// 取车时间，精确到分钟，日期格式yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("pick_up_time")]
        public string PickUpTime { get; set; }

        /// <summary>
        /// 订单总价，单位分，例如订单总价200元，传20000
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户开放平台id
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
