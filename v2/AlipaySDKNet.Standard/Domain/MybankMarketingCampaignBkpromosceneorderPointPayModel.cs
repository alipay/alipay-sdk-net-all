using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignBkpromosceneorderPointPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignBkpromosceneorderPointPayModel : AopObject
    {
        /// <summary>
        /// LinkedMall入驻的业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 请求发起的时间，时间格式：yyyyMMddHHmmssSSS
        /// </summary>
        [XmlElement("deducted_date")]
        public string DeductedDate { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// LinkedMall
        /// </summary>
        [XmlElement("lm_order_id")]
        public long LmOrderId { get; set; }

        /// <summary>
        /// 下单的扩展属性
        /// </summary>
        [XmlElement("merchant_exts")]
        public string MerchantExts { get; set; }

        /// <summary>
        /// 本次下单需要扣减的积分数
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

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
