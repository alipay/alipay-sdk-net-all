using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitContentMiniApp Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitContentMiniApp : AopObject
    {
        /// <summary>
        /// 小程序配置信息列表。
        /// </summary>
        [XmlArray("content_configs")]
        [XmlArrayItem("recruit_content_config")]
        public List<RecruitContentConfig> ContentConfigs { get; set; }

        /// <summary>
        /// 小程序ID。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
