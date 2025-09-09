using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRecruitAttendanceSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryRecruitAttendanceSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付考勤id
        /// </summary>
        [XmlElement("attendance_id")]
        public string AttendanceId { get; set; }
    }
}
