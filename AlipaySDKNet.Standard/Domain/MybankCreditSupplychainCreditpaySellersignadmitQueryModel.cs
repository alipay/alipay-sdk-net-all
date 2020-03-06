using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellersignadmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainCreditpaySellersignadmitQueryModel : AopObject
    {
        /// <summary>
        /// 平台类型
        /// </summary>
        [XmlElement("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 请求冥等控制ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [XmlElement("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 1688店铺ID
        /// </summary>
        [XmlElement("seller_scene_id")]
        public string SellerSceneId { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称，在需要传店铺名称时
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// Trace信息
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
