using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpEcomstoreFeatureQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEcomstoreFeatureQueryModel : AopObject
    {
        /// <summary>
        /// 店铺平台ID
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
