using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRecruitAttendanceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRecruitAttendanceSyncModel : AopObject
    {
        /// <summary>
        /// 考勤打卡信息同步 考勤打卡状态变更
        /// </summary>
        [XmlElement("attendance_type")]
        public string AttendanceType { get; set; }

        /// <summary>
        /// 上班实际打卡时间
        /// </summary>
        [XmlElement("clock_in_real_time")]
        public string ClockInRealTime { get; set; }

        /// <summary>
        /// Y-已打卡，N-未打卡；当状态为Y时，clock_in_real_time必填
        /// </summary>
        [XmlElement("clock_in_status")]
        public string ClockInStatus { get; set; }

        /// <summary>
        /// 上班待打卡时间
        /// </summary>
        [XmlElement("clock_in_time")]
        public string ClockInTime { get; set; }

        /// <summary>
        /// 下班实际打卡时间
        /// </summary>
        [XmlElement("clock_out_real_time")]
        public string ClockOutRealTime { get; set; }

        /// <summary>
        /// Y-已打卡，N-未打卡；当状态为Y时，clock_out_real_time必填
        /// </summary>
        [XmlElement("clock_out_status")]
        public string ClockOutStatus { get; set; }

        /// <summary>
        /// 下班待打卡时间
        /// </summary>
        [XmlElement("clock_out_time")]
        public string ClockOutTime { get; set; }

        /// <summary>
        /// 服务商侧报名ID
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 外部考勤id
        /// </summary>
        [XmlElement("out_attendance_id")]
        public string OutAttendanceId { get; set; }

        /// <summary>
        /// 服务商侧岗位唯一标识
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 考勤信息来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
