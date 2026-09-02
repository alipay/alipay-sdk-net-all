using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AutohomeDistributeStatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AutohomeDistributeStatusModel : AopObject
    {
        /// <summary>
        /// 1:成功 2:失败 3:预留
        /// </summary>
        [XmlElement("clues_distribute_state")]
        public long CluesDistributeState { get; set; }

        /// <summary>
        /// 线索上报线索平台时间
        /// </summary>
        [XmlElement("clues_push_stime")]
        public string CluesPushStime { get; set; }

        /// <summary>
        /// 成交车系ID
        /// </summary>
        [XmlElement("deal_series_id")]
        public string DealSeriesId { get; set; }

        /// <summary>
        /// 0：否 1：是
        /// </summary>
        [XmlElement("deal_status")]
        public long DealStatus { get; set; }

        /// <summary>
        /// 成交时间
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 定向分发失败原因详情
        /// </summary>
        [XmlElement("direct_distribute_fail_detail_reason")]
        public string DirectDistributeFailDetailReason { get; set; }

        /// <summary>
        /// 定向分发失败原因
        /// </summary>
        [XmlElement("direct_distribute_fail_reason")]
        public string DirectDistributeFailReason { get; set; }

        /// <summary>
        /// 1:成功 / 2:失败 / 3:预留
        /// </summary>
        [XmlElement("direct_distribute_state")]
        public long DirectDistributeState { get; set; }

        /// <summary>
        /// 定向分发时间
        /// </summary>
        [XmlElement("direct_distribute_time")]
        public string DirectDistributeTime { get; set; }

        /// <summary>
        /// 最终分发成功时间
        /// </summary>
        [XmlElement("dist_time")]
        public string DistTime { get; set; }

        /// <summary>
        /// 最终分发失败原因详情
        /// </summary>
        [XmlElement("distribute_fail_detail_reason")]
        public string DistributeFailDetailReason { get; set; }

        /// <summary>
        /// 最终分发失败原因
        /// </summary>
        [XmlElement("distribute_fail_reason")]
        public string DistributeFailReason { get; set; }

        /// <summary>
        /// 1：已确认首触 2：已确认非首触
        /// </summary>
        [XmlElement("first_touch")]
        public long FirstTouch { get; set; }

        /// <summary>
        /// 线索最终分发的任务ID
        /// </summary>
        [XmlElement("key_activity_id")]
        public string KeyActivityId { get; set; }

        /// <summary>
        /// 各业务线上报的线索ID
        /// </summary>
        [XmlElement("key_business_id")]
        public string KeyBusinessId { get; set; }

        /// <summary>
        /// 原始定向任务ID
        /// </summary>
        [XmlElement("key_car_age")]
        public string KeyCarAge { get; set; }

        /// <summary>
        /// 产品分类ID
        /// </summary>
        [XmlElement("key_car_all_case")]
        public long KeyCarAllCase { get; set; }

        /// <summary>
        /// 车系ID
        /// </summary>
        [XmlElement("key_car_audi_id")]
        public string KeyCarAudiId { get; set; }

        /// <summary>
        /// 线索定制经销商id
        /// </summary>
        [XmlElement("key_car_img_url")]
        public string KeyCarImgUrl { get; set; }

        /// <summary>
        /// 线索经销商id
        /// </summary>
        [XmlElement("key_distributor_id")]
        public string KeyDistributorId { get; set; }

        /// <summary>
        /// 原始定向子任务ID
        /// </summary>
        [XmlElement("key_ext_1")]
        public string KeyExt1 { get; set; }

        /// <summary>
        /// 成功分发需求业务线名称
        /// </summary>
        [XmlElement("key_need_business_name")]
        public string KeyNeedBusinessName { get; set; }

        /// <summary>
        /// 手机号hashcode
        /// </summary>
        [XmlElement("key_phone_hashcode")]
        public string KeyPhoneHashcode { get; set; }

        /// <summary>
        /// 上报业务线id
        /// </summary>
        [XmlElement("key_supply_business_id")]
        public string KeySupplyBusinessId { get; set; }

        /// <summary>
        /// 同一个keySplitId/keyUniqueId根据这个时间更新线索最新状态
        /// </summary>
        [XmlElement("last_modified_stime")]
        public string LastModifiedStime { get; set; }

        /// <summary>
        /// 线索拆分条数
        /// </summary>
        [XmlElement("split_count")]
        public long SplitCount { get; set; }
    }
}
