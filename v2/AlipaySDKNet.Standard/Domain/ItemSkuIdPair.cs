using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSkuIdPair Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuIdPair : AopObject
    {
        /// <summary>
        /// 商家侧sku ID，APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
