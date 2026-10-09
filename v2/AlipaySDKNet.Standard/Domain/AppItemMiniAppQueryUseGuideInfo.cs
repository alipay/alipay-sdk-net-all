using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemMiniAppQueryUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemMiniAppQueryUseGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序链接
        /// </summary>
        [XmlElement("mini_app_url")]
        public string MiniAppUrl { get; set; }
    }
}
