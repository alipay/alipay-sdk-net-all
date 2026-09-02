using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductSyncItem Data Structure.
    /// </summary>
    [Serializable]
    public class ProductSyncItem : AopObject
    {
        /// <summary>
        /// 商家商品编码与商品条码二选一必填
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品语音播报，只能满足40文字表述
        /// </summary>
        [XmlElement("marketing_voice_text")]
        public string MarketingVoiceText { get; set; }

        /// <summary>
        /// 商家商品编码与商品条码二选一必填
        /// </summary>
        [XmlElement("merchant_product_code")]
        public string MerchantProductCode { get; set; }

        /// <summary>
        /// 原价，单位元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品图片fileId，支持格式：PNG，需要无背景的商品图片，用于生成活动海报等
        /// </summary>
        [XmlElement("product_image_file_id")]
        public string ProductImageFileId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 活动价，单位元
        /// </summary>
        [XmlElement("promotion_price")]
        public string PromotionPrice { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }
    }
}
