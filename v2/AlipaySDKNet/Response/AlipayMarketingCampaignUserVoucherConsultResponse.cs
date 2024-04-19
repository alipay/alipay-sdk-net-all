using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherConsultResponse : AopResponse
    {
        /// <summary>
        /// 活动券领取咨询结果列表
        /// </summary>
        [XmlArray("activity_consult_list")]
        [XmlArrayItem("activity_consult_info")]
        public List<ActivityConsultInfo> ActivityConsultList { get; set; }
    }
}
