using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopReviewCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopReviewCreateModel : AopObject
    {
        /// <summary>
        /// 评价内容id，最长128，需要保证传入的每个评价内容id具备唯一性，有幂等校验
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 数字化门店id；可选，如果传的就使用，如果不传就根据shop_id查询
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 支付宝用户open_id(与user_id二选一)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 评价创建时间
        /// </summary>
        [XmlElement("review_create_time")]
        public string ReviewCreateTime { get; set; }

        /// <summary>
        /// 评价图片信息
        /// </summary>
        [XmlElement("review_images")]
        public string ReviewImages { get; set; }

        /// <summary>
        /// 评价修改时间
        /// </summary>
        [XmlElement("review_modify_time")]
        public string ReviewModifyTime { get; set; }

        /// <summary>
        /// 评价文本信息
        /// </summary>
        [XmlElement("review_text")]
        public string ReviewText { get; set; }

        /// <summary>
        /// 评价视频信息
        /// </summary>
        [XmlElement("review_videos")]
        public string ReviewVideos { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 评分细节(具体样式由业务方提供)
        /// </summary>
        [XmlElement("star_level")]
        public string StarLevel { get; set; }

        /// <summary>
        /// 总条评分(1-5)
        /// </summary>
        [XmlElement("star_level_total")]
        public long StarLevelTotal { get; set; }

        /// <summary>
        /// 交易号，如果是退款交易号会长一些
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
