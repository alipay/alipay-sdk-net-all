using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCreateResponse.
    /// </summary>
    public class AlipayMarketingRecruitEnrollCreateResponse : AopResponse
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
