using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRecruitEnrollCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动报名ID。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 幂等ID。 由商家/ISV 自定义，创建报名时传入的 out_biz_no。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
