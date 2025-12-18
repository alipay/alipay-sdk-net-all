using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfBookingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AxfBookingInfo : AopObject
    {
        /// <summary>
        /// 预约创建时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("booking_create_time")]
        public string BookingCreateTime { get; set; }

        /// <summary>
        /// 预约日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("booking_date")]
        public string BookingDate { get; set; }

        /// <summary>
        /// 预约单id
        /// </summary>
        [XmlElement("booking_id")]
        public string BookingId { get; set; }

        /// <summary>
        /// 预约关联的卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 预约结束时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 预约人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 外部预约单id
        /// </summary>
        [XmlElement("out_booking_id")]
        public string OutBookingId { get; set; }

        /// <summary>
        /// 预约人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 预约备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 预约项目id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 预约开始时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 预约状态（枚举） pending      预约待确认 confirmed    预约成功（已确认，待履约） completed    履约完成 canceled     预约取消 expired      预约过期（未履约且超过有效期）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 预约手艺人id
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }
    }
}
