using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuCustomizeTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuCustomizeTransferModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("fans_id")]
        public string FansId { get; set; }

        /// <summary>
        /// 必填 OPEN_UID-鲸探OPEN_UID PHONE_NO-手机号
        /// </summary>
        [XmlElement("fans_id_type")]
        public string FansIdType { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 资源文件Id
        /// </summary>
        [XmlElement("source_file_id")]
        public string SourceFileId { get; set; }

        /// <summary>
        /// 贴图文件Id
        /// </summary>
        [XmlElement("sticker_file_id")]
        public string StickerFileId { get; set; }

        /// <summary>
        /// 合作方交易唯一识别号
        /// </summary>
        [XmlElement("third_biz_no")]
        public string ThirdBizNo { get; set; }

        /// <summary>
        /// 缩略图文件Id
        /// </summary>
        [XmlElement("thumbnail_file_id")]
        public string ThumbnailFileId { get; set; }
    }
}
