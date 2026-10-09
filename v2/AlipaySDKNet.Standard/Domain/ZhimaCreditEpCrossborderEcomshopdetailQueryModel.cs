using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCrossborderEcomshopdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCrossborderEcomshopdetailQueryModel : AopObject
    {
        /// <summary>
        /// 授权编号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

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
