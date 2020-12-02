using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopAppRelation Data Structure.
    /// </summary>
    [Serializable]
    public class ShopAppRelation : AopObject
    {
        /// <summary>
        /// 支付宝门店ID，在支付宝商户平台维护的线下门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 待绑定的支付宝小程序ID
        /// </summary>
        [XmlElement("store_app_id")]
        public string StoreAppId { get; set; }
    }
}
