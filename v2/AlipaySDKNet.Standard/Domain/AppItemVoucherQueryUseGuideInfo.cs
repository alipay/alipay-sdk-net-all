using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQueryUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQueryUseGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序核销详情
        /// </summary>
        [XmlElement("app_item_mini_app_use_guide_info")]
        public AppItemMiniAppQueryUseGuideInfo AppItemMiniAppUseGuideInfo { get; set; }

        /// <summary>
        /// 核销引导模式
        /// </summary>
        [XmlArray("use_guide_mode")]
        [XmlArrayItem("string")]
        public List<string> UseGuideMode { get; set; }
    }
}
