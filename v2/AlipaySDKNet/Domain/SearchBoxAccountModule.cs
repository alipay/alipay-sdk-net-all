using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxAccountModule Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxAccountModule : AopObject
    {
        /// <summary>
        /// 应用信息列表
        /// </summary>
        [XmlArray("app_infos")]
        [XmlArrayItem("search_box_app_info")]
        public List<SearchBoxAppInfo> AppInfos { get; set; }

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
    }
}
