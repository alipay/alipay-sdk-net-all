using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxBusinessDistrictModule Data Structure.
    /// </summary>
    [Serializable]
    public class BoxBusinessDistrictModule : AopObject
    {
        /// <summary>
        /// 商圈选择
        /// </summary>
        [XmlArray("business_district_infos")]
        [XmlArrayItem("box_business_district_info")]
        public List<BoxBusinessDistrictInfo> BusinessDistrictInfos { get; set; }

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
