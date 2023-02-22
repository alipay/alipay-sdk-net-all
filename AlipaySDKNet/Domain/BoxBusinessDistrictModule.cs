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
        /// 模块ID
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图/BOX_BUSINESS_DISTRICT-商圈信息/BOX_EXCLUSIVE_AREA_KEYWORD-地域触发词
        /// </summary>
        [XmlElement("module_type")]
        public string ModuleType { get; set; }
    }
}
