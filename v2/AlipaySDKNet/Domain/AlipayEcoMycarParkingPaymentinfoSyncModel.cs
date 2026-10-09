using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingPaymentinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingPaymentinfoSyncModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 停车消息透出后，消息详情的落地承接页链接，可配置ISV维度的统一值
        /// </summary>
        [XmlElement("isv_url")]
        public string IsvUrl { get; set; }

        /// <summary>
        /// 外部业务停车流水号(用于串通进场与出场信息)。如果 out_serial_no与serial_no都传递，则一起校验。 ● serial_no与out_serial_no二选一必填。 ● 入参有serial_no和out_serial_no，则优先根据serial_no和out_serial_no一起匹配进出场事件 ● 入参仅有serial_no，则优先根据serial_no匹配进出场事件 ● 入参仅有out_serial_no，则根据out_serial_no匹配进出场事件
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create(录入停车场信息)接口获取。
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场内缴费后，允许出场的免费时长分钟数
        /// </summary>
        [XmlElement("payment_free_minutes")]
        public long PaymentFreeMinutes { get; set; }

        /// <summary>
        /// 场内缴费时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制，请保证服务器时间准确，场内缴费不应晚于当前网络时间
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 支付宝业务流水号(用于串通进场与出场信息)。可通过 alipay.eco.mycar.parking.enterinfo.sync (车辆驶入接口)接口获取。 ● serial_no与out_serial_no二选一必填。 ● 入参有serial_no和out_serial_no，则优先根据serial_no和out_serial_no一起匹配进出场事件 ● 入参仅有serial_no，则优先根据serial_no匹配进出场事件 ● 入参仅有out_serial_no，则根据out_serial_no匹配进出场事件
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
