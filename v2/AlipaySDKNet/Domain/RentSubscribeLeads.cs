using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSubscribeLeads Data Structure.
    /// </summary>
    [Serializable]
    public class RentSubscribeLeads : AopObject
    {
        /// <summary>
        /// 约定看房日期
        /// </summary>
        [XmlElement("appointment_date")]
        public string AppointmentDate { get; set; }

        /// <summary>
        /// 约定看房时间段
        /// </summary>
        [XmlElement("appointment_time")]
        public string AppointmentTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 租客手机号
        /// </summary>
        [XmlElement("renter_mobile_num")]
        public string RenterMobileNum { get; set; }

        /// <summary>
        /// 租客称呼
        /// </summary>
        [XmlElement("renter_name")]
        public string RenterName { get; set; }

        /// <summary>
        /// 商家侧房屋唯一编码
        /// </summary>
        [XmlElement("room_code")]
        public string RoomCode { get; set; }
    }
}
