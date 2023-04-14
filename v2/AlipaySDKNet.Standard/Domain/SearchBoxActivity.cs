using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxActivity Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxActivity : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("box_activity_id")]
        public string BoxActivityId { get; set; }

        /// <summary>
        /// 搜索直达id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// IMAGE-图片/VIDEO-视频
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 当material_type="IMAGE"时，为图片url；当material_type="VIDEO"时，为视频url
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }

        /// <summary>
        /// 运行状态，INITIAL-初始，ONLINE-已上架，EXPIRE-已失效，OFFLINE-已下架
        /// </summary>
        [XmlElement("run_status")]
        public string RunStatus { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 配置状态，INITIAL-初始/AUDIT-审核中/CANCEL-已取消/ONLINE-已上架/REJECT-驳回/OFFLINE-已下架/EXPIRE-已失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 跳转应用ID
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }

        /// <summary>
        /// 目标小程序名称
        /// </summary>
        [XmlElement("target_appname")]
        public string TargetAppname { get; set; }

        /// <summary>
        /// 投放目标区域
        /// </summary>
        [XmlArray("target_regions")]
        [XmlArrayItem("delivery_target_region")]
        public List<DeliveryTargetRegion> TargetRegions { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 搜索直达活动视频信息
        /// </summary>
        [XmlElement("video_info")]
        public SearchBoxActivityVideoInfo VideoInfo { get; set; }
    }
}
