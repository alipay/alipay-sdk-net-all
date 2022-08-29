using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序核销引导
        /// </summary>
        [XmlElement("mini_app_use_guide_info")]
        public VoucherMiniAppUseGuideInfo MiniAppUseGuideInfo { get; set; }

        /// <summary>
        /// 使用引导模式
        /// </summary>
        [XmlArray("use_guide_mode")]
        [XmlArrayItem("string")]
        public List<string> UseGuideMode { get; set; }
    }
}
