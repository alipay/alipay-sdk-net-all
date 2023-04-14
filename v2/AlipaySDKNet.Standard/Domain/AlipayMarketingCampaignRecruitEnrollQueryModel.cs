using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignRecruitEnrollQueryModel : AopObject
    {
        /// <summary>
        /// 活动报名ID。 创建活动报名时返回的 enroll_id。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 幂等ID。 创建报名时传入的 out_biz_no。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
