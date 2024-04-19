using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskHunterGetResponse.
    /// </summary>
    public class AlipayCommerceYuntaskHunterGetResponse : AopResponse
    {
        /// <summary>
        /// 任务信息
        /// </summary>
        [XmlElement("task_instance_info")]
        public TaskInstanceInfo TaskInstanceInfo { get; set; }

        /// <summary>
        /// 标的物信息
        /// </summary>
        [XmlArray("task_marker_info_list")]
        [XmlArrayItem("task_marker_info")]
        public List<TaskMarkerInfo> TaskMarkerInfoList { get; set; }

        /// <summary>
        /// 任务券信息
        /// </summary>
        [XmlArray("task_voucher_list")]
        [XmlArrayItem("task_voucher_basic_info")]
        public List<TaskVoucherBasicInfo> TaskVoucherList { get; set; }

        /// <summary>
        /// 排名信息
        /// </summary>
        [XmlArray("user_ranking_info_list")]
        [XmlArrayItem("task_point_rank_info")]
        public List<TaskPointRankInfo> UserRankingInfoList { get; set; }
    }
}
