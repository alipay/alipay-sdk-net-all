using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQipanCrowdwithtagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQipanCrowdwithtagQueryModel : AopObject
    {
        /// <summary>
        /// 人群id，人群二次加工时必传
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 选择的标签列表信息
        /// </summary>
        [XmlArray("select_tag_list")]
        [XmlArrayItem("crowd_select_tag_open_request")]
        public List<CrowdSelectTagOpenRequest> SelectTagList { get; set; }
    }
}
