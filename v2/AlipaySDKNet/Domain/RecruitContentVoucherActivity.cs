using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitContentVoucherActivity Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitContentVoucherActivity : AopObject
    {
        /// <summary>
        /// 券活动ID。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券活动配置信息列表。
        /// </summary>
        [XmlArray("content_configs")]
        [XmlArrayItem("recruit_content_config")]
        public List<RecruitContentConfig> ContentConfigs { get; set; }
    }
}
