using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarJvorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarJvorderSyncModel : AopObject
    {
        /// <summary>
        /// 实际取车时间，即为完单时间
        /// </summary>
        [XmlElement("actual_pick_up_time")]
        public string ActualPickUpTime { get; set; }

        /// <summary>
        /// 订单优惠总金额，单位分。
        /// </summary>
        [XmlElement("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 还车门店名称
        /// </summary>
        [XmlElement("drop_off_store_name")]
        public string DropOffStoreName { get; set; }

        /// <summary>
        /// 完单时间，当正常完单时即为实际取车时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// JV出资优惠金额，单位分
        /// </summary>
        [XmlElement("jv_discount_amount")]
        public long JvDiscountAmount { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单渠道
        /// </summary>
        [XmlElement("order_channel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单状态，状态机： CREATED—>WAIT_ISV_SUBMIT—>CONFIRMING—>WAIT_PICK_UP—>PICKED_UP—>COMPLETED。除了PICKED_UP和COMPLETED不能流转为CANCELED，其他状态均可流转为CANCELED
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 非JV出资优惠金额，单位分
        /// </summary>
        [XmlElement("other_discount_amount")]
        public long OtherDiscountAmount { get; set; }

        /// <summary>
        /// JV租车订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// JV租车收款商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单实付金额，单位分。订单总金额-订单优惠金额=订单实付金额。
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 取车门店名称
        /// </summary>
        [XmlElement("pick_up_store_name")]
        public string PickUpStoreName { get; set; }

        /// <summary>
        /// 预计还车时间
        /// </summary>
        [XmlElement("plan_drop_off_time")]
        public string PlanDropOffTime { get; set; }

        /// <summary>
        /// 预计取车时间
        /// </summary>
        [XmlElement("plan_pick_up_time")]
        public string PlanPickUpTime { get; set; }

        /// <summary>
        /// 券前订单总金额，单位分。
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车型品牌名
        /// </summary>
        [XmlElement("vehicle_brand_name")]
        public string VehicleBrandName { get; set; }

        /// <summary>
        /// 车辆颜色
        /// </summary>
        [XmlElement("vehicle_color")]
        public string VehicleColor { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("vehicle_plate_no")]
        public string VehiclePlateNo { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [XmlElement("vehicle_seat_num")]
        public string VehicleSeatNum { get; set; }

        /// <summary>
        /// 车型车系名
        /// </summary>
        [XmlElement("vehicle_series_name")]
        public string VehicleSeriesName { get; set; }

        /// <summary>
        /// 车型展示名称
        /// </summary>
        [XmlElement("vehicle_show_name")]
        public string VehicleShowName { get; set; }
    }
}
