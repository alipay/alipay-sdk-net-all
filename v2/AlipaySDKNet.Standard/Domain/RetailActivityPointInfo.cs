using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RetailActivityPointInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RetailActivityPointInfo : AopObject
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 消耗积分数量
        /// </summary>
        [XmlElement("point_amount_floor")]
        public string PointAmountFloor { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlArray("prize_info")]
        [XmlArrayItem("prize_detail_info")]
        public List<PrizeDetailInfo> PrizeInfo { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("retail_activity_id")]
        public string RetailActivityId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
