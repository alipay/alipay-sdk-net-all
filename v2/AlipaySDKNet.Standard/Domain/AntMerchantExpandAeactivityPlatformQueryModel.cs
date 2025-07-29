using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAeactivityPlatformQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAeactivityPlatformQueryModel : AopObject
    {
        /// <summary>
        /// 饿了么门店shopId
        /// </summary>
        [XmlElement("ele_shopid")]
        public string EleShopid { get; set; }
    }
}
