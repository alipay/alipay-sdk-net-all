using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxAreaKeyWordModule Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxAreaKeyWordModule : AopObject
    {
        /// <summary>
        /// 地域触发词信息 (最近一次审核内容)
        /// </summary>
        [XmlElement("latest_audit_area_keyword_info")]
        public SearchBoxKeywordInfo LatestAuditAreaKeywordInfo { get; set; }

        /// <summary>
        /// 模块配置ID
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型
        /// </summary>
        [XmlElement("module_type")]
        public string ModuleType { get; set; }

        /// <summary>
        /// 地域触发词信息 (审核通过内容)
        /// </summary>
        [XmlElement("valid_area_keyword_info")]
        public SearchBoxKeywordInfo ValidAreaKeywordInfo { get; set; }
    }
}
