using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderSyncModel : AopObject
    {
        /// <summary>
        /// 该笔停车交易需要返佣的对象实体PID，可能是商户，可能是ISV；只做下沉，用于离线表层面对账。
        /// </summary>
        [XmlElement("agent_pid")]
        public string AgentPid { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 如果是停车卡缴费，则填入停车卡卡号，否则为'*'
        /// </summary>
        [XmlElement("card_number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// 停车时长（以分为单位）
        /// </summary>
        [XmlElement("in_duration")]
        public string InDuration { get; set; }

        /// <summary>
        /// 入场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 应用用户ID，唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝支付流水，系统唯一
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 设备商订单状态，枚举支持： * 0：成功。 * 1：失败。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单创建时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 设备商订单号，由ISV系统生成
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，同一个isv或商户范围内唯一。需与 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口传入值一致。
        /// </summary>
        [XmlElement("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 出场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口获取。
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称，需与<a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口传入值一致。
        /// </summary>
        [XmlElement("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程。通过 alipay.eco.mycar.parking.enterinfo.sync(车辆驶入接口)接口获取。
        /// </summary>
        [XmlElement("parking_record_id")]
        public string ParkingRecordId { get; set; }

        /// <summary>
        /// 缴费金额，保留小数点后两位
        /// </summary>
        [XmlElement("pay_money")]
        public string PayMoney { get; set; }

        /// <summary>
        /// 支付场景：INPARKINGLOT_PAY：场内在线缴费；ENTRANCE_EXIT_PAY：出入口缴费、VEH_DEVICE_PAY：车机缴费；会根据场景判断是否发放能量，当前只有场内支付场景会发能量，需要能量发放请与服务接入支持同学提前沟通。
        /// </summary>
        [XmlElement("pay_scene")]
        public string PayScene { get; set; }

        /// <summary>
        /// 缴费时间, 格式"YYYYMM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 付款方式，枚举支持： *1：支付宝在线缴费。
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 间连商户ID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 停车缴费用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 注意：ISV需保证用户 id的正确性，以免导致用户在停车平台查询不到相关的订单信息。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
