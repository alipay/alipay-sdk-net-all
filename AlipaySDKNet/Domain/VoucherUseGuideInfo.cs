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
        /// OFFLINE_CODE 券码扫码核销 MINI_APP 小程序线上核销 SCAN_CODE 跳转付款码支付核销 CAN_USE 展示可使用
        /// </summary>
        [XmlArray("use_guide_mode")]
        [XmlArrayItem("string")]
        public List<string> UseGuideMode { get; set; }
    }
}
