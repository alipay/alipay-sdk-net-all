using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxServiceModule Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxServiceModule : AopObject
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图
        /// </summary>
        [XmlElement("module_type")]
        public string ModuleType { get; set; }

        /// <summary>
        /// 服务信息列表
        /// </summary>
        [XmlArray("service_infos")]
        [XmlArrayItem("search_box_service_info")]
        public List<SearchBoxServiceInfo> ServiceInfos { get; set; }
    }
}
