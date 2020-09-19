using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolcreditConfirmResponse.
    /// </summary>
    public class AlipayOverseasTuitionSchoolcreditConfirmResponse : AopResponse
    {
        /// <summary>
        /// 业务透传保留字段，json map格式
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
