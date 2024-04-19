using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InquiryDoctorShiftCaseData Data Structure.
    /// </summary>
    [Serializable]
    public class InquiryDoctorShiftCaseData : AopObject
    {
        /// <summary>
        /// 外部排班编码
        /// </summary>
        [XmlElement("ext_shift_case_id")]
        public string ExtShiftCaseId { get; set; }

        /// <summary>
        /// 可预约人数
        /// </summary>
        [XmlElement("register_num")]
        public string RegisterNum { get; set; }

        /// <summary>
        /// 是否可预约
        /// </summary>
        [XmlElement("register_status")]
        public bool RegisterStatus { get; set; }

        /// <summary>
        /// 问诊预约日期
        /// </summary>
        [XmlElement("shift_date")]
        public string ShiftDate { get; set; }

        /// <summary>
        /// 若为预约制，则必填 格式： 时间点-hh:mm 时间段-hh:mm-hh:mm
        /// </summary>
        [XmlElement("shift_time_slot")]
        public string ShiftTimeSlot { get; set; }

        /// <summary>
        /// 时间点/时间段/时间区间
        /// </summary>
        [XmlElement("shift_time_slot_type")]
        public string ShiftTimeSlotType { get; set; }
    }
}
