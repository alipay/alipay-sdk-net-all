using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUserVoucherConsultModel : AopObject
    {
        /// <summary>
        /// 活动id列表
        /// </summary>
        [XmlArray("activity_id_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityIdList { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [XmlArray("scene_code")]
        [XmlArrayItem("string")]
        public List<string> SceneCode { get; set; }
    }
}
