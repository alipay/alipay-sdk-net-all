using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOvertimecharginginfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOvertimecharginginfoSyncModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 智能助理当前的跳转链接
        /// </summary>
        [XmlElement("isv_url")]
        public string IsvUrl { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create(录入停车场信息)接口获取。
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
