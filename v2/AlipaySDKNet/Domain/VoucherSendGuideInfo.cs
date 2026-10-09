using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序发放引导
        /// </summary>
        [XmlElement("mini_app_send_guide_info")]
        public VoucherMiniAppSendGuideInfo MiniAppSendGuideInfo { get; set; }

        /// <summary>
        /// 发放引导模式
        /// </summary>
        [XmlArray("send_guide_mode")]
        [XmlArrayItem("string")]
        public List<string> SendGuideMode { get; set; }
    }
}
