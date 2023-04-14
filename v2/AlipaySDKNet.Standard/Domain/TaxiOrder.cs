using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TaxiOrder : AopObject
    {
        /// <summary>
        /// 出租车外部订单号
        /// </summary>
        [XmlElement("business_order_no")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机open_id
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 司机userId
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

        /// <summary>
        /// 行程结束时间，如果未关联到行程，使用支付时间
        /// </summary>
        [XmlElement("end_trip_time")]
        public string EndTripTime { get; set; }

        /// <summary>
        /// 行程开始时间
        /// </summary>
        [XmlElement("start_trip_time")]
        public string StartTripTime { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }
    }
}
