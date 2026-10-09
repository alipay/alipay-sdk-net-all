using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopRatingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopRatingInfo : AopObject
    {
        /// <summary>
        /// 物流评分（5分制，单位：分）
        /// </summary>
        [XmlElement("delivery_score")]
        public string DeliveryScore { get; set; }

        /// <summary>
        /// 商品描述评分（5分制，单位：分）
        /// </summary>
        [XmlElement("itemdesc_score")]
        public string ItemdescScore { get; set; }

        /// <summary>
        /// 服务评分（5分制，单位：分）
        /// </summary>
        [XmlElement("service_score")]
        public string ServiceScore { get; set; }
    }
}
