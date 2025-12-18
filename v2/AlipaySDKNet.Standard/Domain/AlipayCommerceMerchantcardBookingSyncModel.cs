using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardBookingSyncModel : AopObject
    {
        /// <summary>
        /// 预约动作（枚举） create   - 创建预约单 confirm  - 确认预约单 cancel   - 取消预约单 update   - 修改预约单（如改期、换服务等） complete - 将预约单置为履约完成
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 预约日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("booking_date")]
        public string BookingDate { get; set; }

        /// <summary>
        /// 预约单id【confirm/cancel/update/complete必填】
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
        /// 门店id【必填】
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 预约开始时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 预约手艺人id
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }
    }
}
