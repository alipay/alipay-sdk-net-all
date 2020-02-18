using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [XmlArray("member_template_ids")]
        [XmlArrayItem("string")]
        public List<string> MemberTemplateIds { get; set; }
    }
}
