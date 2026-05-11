using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuCampaignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuCampaignCreateModel : AopObject
    {
        /// <summary>
        /// 活动业务类型 
        /// </summary>
        [XmlElement("camp_biz_type")]
        public string CampBizType { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("camp_name")]
        public string CampName { get; set; }

        /// <summary>
        /// 必填，string时间类型，格式为“年月日时分秒”
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 人群ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// sku的id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 必填，string时间类型，格式为“年月日时分秒”
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
