using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskHunterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskHunterQueryModel : AopObject
    {
        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 任务类型 RECEIVED: 已领取任务 RECOMMENDED: 推荐任务 FINISHED：领取的已结束任务 EXCHANGEABLE：可兑换的任务
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
