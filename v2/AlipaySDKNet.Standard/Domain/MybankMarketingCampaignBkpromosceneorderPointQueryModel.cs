using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignBkpromosceneorderPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignBkpromosceneorderPointQueryModel : AopObject
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 下单之前的扩展信息
        /// </summary>
        [XmlElement("merchant_exts")]
        public string MerchantExts { get; set; }

        /// <summary>
        /// sku_id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
