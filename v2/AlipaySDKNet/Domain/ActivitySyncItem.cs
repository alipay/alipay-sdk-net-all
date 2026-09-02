using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivitySyncItem Data Structure.
    /// </summary>
    [Serializable]
    public class ActivitySyncItem : AopObject
    {
        /// <summary>
        /// 单次同步活动商品只能维护20种，超过20种需要上传完整活动商品，则需要分批上传，用于描述所属具体活动id的批次
        /// </summary>
        [XmlElement("activity_batch_id")]
        public string ActivityBatchId { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("activity_description")]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动Slogan
        /// </summary>
        [XmlElement("activity_slogan")]
        public string ActivitySlogan { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 支付宝定义的活动类型，严格要求按照
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 用于表述商家的具体活动Id
        /// </summary>
        [XmlElement("merchant_activity_id")]
        public string MerchantActivityId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("products")]
        [XmlArrayItem("product_sync_item")]
        public List<ProductSyncItem> Products { get; set; }

        /// <summary>
        /// 支付宝定义来源渠道编码，必须按照规范传入
        /// </summary>
        [XmlElement("source_channel_code")]
        public string SourceChannelCode { get; set; }

        /// <summary>
        /// 来源渠道名称
        /// </summary>
        [XmlElement("source_channel_name")]
        public string SourceChannelName { get; set; }

        /// <summary>
        /// 上传的文件Id，图片大小60*60，单个文件不超过50kb，支持格式：JPG/JPEG/PNG
        /// </summary>
        [XmlElement("source_logo")]
        public string SourceLogo { get; set; }
    }
}
