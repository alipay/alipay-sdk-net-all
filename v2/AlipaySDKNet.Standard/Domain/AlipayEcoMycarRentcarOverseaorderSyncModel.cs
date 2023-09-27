using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarOverseaorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarOverseaorderSyncModel : AopObject
    {
        /// <summary>
        /// 续租交易信息
        /// </summary>
        [XmlElement("add_rent_trade_list")]
        public AddRentTradeInfo AddRentTradeList { get; set; }

        /// <summary>
        /// 分润基数，单位元。注意，这里单位是元。已支付必传
        /// </summary>
        [XmlElement("applets_service_amount")]
        public long AppletsServiceAmount { get; set; }

        /// <summary>
        /// 分润类目。已支付必传
        /// </summary>
        [XmlElement("applets_service_category")]
        public string AppletsServiceCategory { get; set; }

        /// <summary>
        /// 取消违约费，单位分
        /// </summary>
        [XmlElement("cancelled_amount")]
        public long CancelledAmount { get; set; }

        /// <summary>
        /// 车生活车型id
        /// </summary>
        [XmlElement("carlife_vehicle_id")]
        public string CarlifeVehicleId { get; set; }

        /// <summary>
        /// 押金金额，单位分
        /// </summary>
        [XmlElement("deposit_amount")]
        public long DepositAmount { get; set; }

        /// <summary>
        /// 押金扣款金额，单位分
        /// </summary>
        [XmlElement("deposit_deduct_amount")]
        public long DepositDeductAmount { get; set; }

        /// <summary>
        /// 订单折扣（优惠）金额，单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 车型排量
        /// </summary>
        [XmlElement("displacement")]
        public string Displacement { get; set; }

        /// <summary>
        /// 驾驶人手机号。待支付状态必传
        /// </summary>
        [XmlElement("driver_mobile")]
        public string DriverMobile { get; set; }

        /// <summary>
        /// 驾驶人姓名。待支付状态必传
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 租赁期间行驶里程，单位公里
        /// </summary>
        [XmlElement("driving_distance")]
        public long DrivingDistance { get; set; }

        /// <summary>
        /// 还车地址。待支付必传
        /// </summary>
        [XmlElement("drop_off_address")]
        public string DropOffAddress { get; set; }

        /// <summary>
        /// 还车城市代码。待支付必传
        /// </summary>
        [XmlElement("drop_off_city_code")]
        public string DropOffCityCode { get; set; }

        /// <summary>
        /// 还车城市名名称。待支付必传
        /// </summary>
        [XmlElement("drop_off_city_name")]
        public string DropOffCityName { get; set; }

        /// <summary>
        /// 还车地区代码。待支付必传
        /// </summary>
        [XmlElement("drop_off_region_code")]
        public string DropOffRegionCode { get; set; }

        /// <summary>
        /// 还车地区名称。待支付必传
        /// </summary>
        [XmlElement("drop_off_region_name")]
        public string DropOffRegionName { get; set; }

        /// <summary>
        /// 还车网点名称。待支付必传
        /// </summary>
        [XmlElement("drop_off_store_name")]
        public string DropOffStoreName { get; set; }

        /// <summary>
        /// 还车时间。待支付必传
        /// </summary>
        [XmlElement("drop_off_time")]
        public string DropOffTime { get; set; }

        /// <summary>
        /// 用户补款金额，单位分
        /// </summary>
        [XmlElement("fill_amount")]
        public long FillAmount { get; set; }

        /// <summary>
        /// 是否有续租
        /// </summary>
        [XmlElement("has_continue_rent")]
        public bool HasContinueRent { get; set; }

        /// <summary>
        /// 是否有车损
        /// </summary>
        [XmlElement("has_damage")]
        public bool HasDamage { get; set; }

        /// <summary>
        /// 是否提前换车
        /// </summary>
        [XmlElement("has_early_give_back")]
        public bool HasEarlyGiveBack { get; set; }

        /// <summary>
        /// 是否有违章
        /// </summary>
        [XmlElement("has_violation")]
        public bool HasViolation { get; set; }

        /// <summary>
        /// 是否上门送取车
        /// </summary>
        [XmlElement("home_get_and_send")]
        public bool HomeGetAndSend { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单状态，状态机： 待支付->已取消，待支付->已关闭，待支付->已支付； 已支付->已取消，已支付->已确认； 已确认->已取消；
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 是否异地取还车
        /// </summary>
        [XmlElement("other_drop_off")]
        public bool OtherDropOff { get; set; }

        /// <summary>
        /// 商户侧订单号，支付宝侧通过商户pid+out_order_no进行订单唯一性校验
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部订单下单时间
        /// </summary>
        [XmlElement("out_order_time")]
        public string OutOrderTime { get; set; }

        /// <summary>
        /// 订单实付金额，单位分。订单总金额-折扣金额=实付金额。已支付必传
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 订单支付时间。已支付必传
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 取车地址。待支付必传
        /// </summary>
        [XmlElement("pick_up_address")]
        public string PickUpAddress { get; set; }

        /// <summary>
        /// 取车城市代码。待支付必传
        /// </summary>
        [XmlElement("pick_up_city_code")]
        public string PickUpCityCode { get; set; }

        /// <summary>
        /// 取车城市名称。待支付必传
        /// </summary>
        [XmlElement("pick_up_city_name")]
        public string PickUpCityName { get; set; }

        /// <summary>
        /// 取车地区代码。待支付必传
        /// </summary>
        [XmlElement("pick_up_region_code")]
        public string PickUpRegionCode { get; set; }

        /// <summary>
        /// 取车地区名称。待支付必传
        /// </summary>
        [XmlElement("pick_up_region_name")]
        public string PickUpRegionName { get; set; }

        /// <summary>
        /// 取车网点名称。待支付必传
        /// </summary>
        [XmlElement("pick_up_store_name")]
        public string PickUpStoreName { get; set; }

        /// <summary>
        /// 取车时间。待支付必传
        /// </summary>
        [XmlElement("pick_up_time")]
        public string PickUpTime { get; set; }

        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 租车公司名称。待支付必传
        /// </summary>
        [XmlElement("rent_company_name")]
        public string RentCompanyName { get; set; }

        /// <summary>
        /// 门店还车联系电话
        /// </summary>
        [XmlElement("store_drop_off_phone")]
        public string StoreDropOffPhone { get; set; }

        /// <summary>
        /// 门店取车联系电话
        /// </summary>
        [XmlElement("store_pick_up_phone")]
        public string StorePickUpPhone { get; set; }

        /// <summary>
        /// 订单总金额，单位分。待支付必传
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 用户支付租金的支付宝交易号，已支付状态必传
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 档位类型，自动挡或手动挡。待支付必传
        /// </summary>
        [XmlElement("transmission_type")]
        public string TransmissionType { get; set; }

        /// <summary>
        /// 单价（日均价），单位分。待支付必传
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车型品牌名
        /// </summary>
        [XmlElement("vehicle_brand_name")]
        public string VehicleBrandName { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("vehicle_plate_no")]
        public string VehiclePlateNo { get; set; }

        /// <summary>
        /// 车型车系名
        /// </summary>
        [XmlElement("vehicle_series_name")]
        public string VehicleSeriesName { get; set; }

        /// <summary>
        /// 车型展示名称。待支付必传
        /// </summary>
        [XmlElement("vehicle_show_name")]
        public string VehicleShowName { get; set; }
    }
}
