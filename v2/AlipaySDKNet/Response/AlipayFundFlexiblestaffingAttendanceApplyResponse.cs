using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAttendanceApplyResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingAttendanceApplyResponse : AopResponse
    {
        /// <summary>
        /// 考勤跳转链接
        /// </summary>
        [XmlElement("apply_link")]
        public string ApplyLink { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [XmlElement("flow_token")]
        public string FlowToken { get; set; }
    }
}
