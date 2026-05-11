using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OnlineShopClasses Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineShopClasses : AopObject
    {
        /// <summary>
        /// 电商平台名称
        /// </summary>
        [XmlElement("platform_name")]
        public string PlatformName { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
