using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuCastSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuCastSubmitModel : AopObject
    {
        /// <summary>
        /// 申请单号必须保证唯一
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 藏品的作者
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 创作日期，格式必须为yyyy-MM-dd
        /// </summary>
        [XmlElement("creation_time")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 发行藏品的自然人或公司
        /// </summary>
        [XmlElement("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// 发行数量 0 代表不限量藏品
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 藏品标颜色
        /// </summary>
        [XmlElement("sku_ac_color")]
        public string SkuAcColor { get; set; }

        /// <summary>
        /// 藏品分类(一级)
        /// </summary>
        [XmlElement("sku_class")]
        public string SkuClass { get; set; }

        /// <summary>
        /// 作品简介
        /// </summary>
        [XmlElement("sku_introduction")]
        public string SkuIntroduction { get; set; }

        /// <summary>
        /// 作品名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// 作品类型 IMAGE-图片 AUDIO-音频 VIDEO-视频 THREE_DIMENSIONS-3D作品 AR-场景藏品
        /// </summary>
        [XmlElement("sku_type")]
        public string SkuType { get; set; }

        /// <summary>
        /// 关联藏品资源文件的鲸造模型ID
        /// </summary>
        [XmlElement("source_file_model_id")]
        public string SourceFileModelId { get; set; }

        /// <summary>
        /// 藏品分类(二级级)
        /// </summary>
        [XmlElement("sub_sku_class")]
        public string SubSkuClass { get; set; }

        /// <summary>
        /// 关联藏品缩略图的鲸造模型ID
        /// </summary>
        [XmlElement("thumbnail_model_id")]
        public string ThumbnailModelId { get; set; }

        /// <summary>
        /// 不限量藏品，AC编码透出字符，只能是包含字母和数字
        /// </summary>
        [XmlElement("unlimited_ac_code")]
        public string UnlimitedAcCode { get; set; }
    }
}
