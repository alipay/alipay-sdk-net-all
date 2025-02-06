using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRecruitApplySyncResponse.
    /// </summary>
    public class AlipayEbppIndustryRecruitApplySyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝就业频道应聘id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 快招报名ID
        /// </summary>
        [XmlElement("recruit_apply_id")]
        public string RecruitApplyId { get; set; }
    }
}
