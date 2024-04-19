using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JumpInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JumpInfo : AopObject
    {
        /// <summary>
        /// 安卓系统的package名称。注意：必须是安卓系统才有
        /// </summary>
        [XmlElement("app_identifier")]
        public string AppIdentifier { get; set; }

        /// <summary>
        /// 用于推进支付流程的 Android App Links 或 iOS Universal Links。
        /// </summary>
        [XmlElement("applink_url")]
        public string ApplinkUrl { get; set; }

        /// <summary>
        /// HTTPS 地址的 URL，用于同一个浏览器页面跳转至支付方式页面。
        /// </summary>
        [XmlElement("normal_url")]
        public string NormalUrl { get; set; }

        /// <summary>
        /// 用于打开支付方式 app 的 scheme URL。
        /// </summary>
        [XmlElement("scheme_url")]
        public string SchemeUrl { get; set; }
    }
}
