using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopVO Data Structure.
    /// </summary>
    [Serializable]
    public class ShopVO : AopObject
    {
        /// <summary>
        /// 店铺状态
        /// </summary>
        [XmlElement("auth_state")]
        public string AuthState { get; set; }

        /// <summary>
        /// 采购方id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }

        /// <summary>
        /// 店铺编码
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
