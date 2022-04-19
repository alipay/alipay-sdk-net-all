using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxAppInfo : AopObject
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用类型，TINY_APP-小程序/PUBLIC_APP-生活号/SHOP_APP-门店应用
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("relate_appid")]
        public string RelateAppid { get; set; }
    }
}
