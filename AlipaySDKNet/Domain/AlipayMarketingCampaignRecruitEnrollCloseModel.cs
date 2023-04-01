using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignRecruitEnrollCloseModel : AopObject
    {
        /// <summary>
        /// 活动报名ID。 创建活动报名时返回的 enroll_id。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }
    }
}
