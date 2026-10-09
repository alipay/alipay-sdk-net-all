using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemMiniAppUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemMiniAppUseGuideInfo : AopObject
    {
        /// <summary>
        /// 跳转指定小程序页面路径
        /// </summary>
        [XmlElement("mini_app_url")]
        public string MiniAppUrl { get; set; }
    }
}
