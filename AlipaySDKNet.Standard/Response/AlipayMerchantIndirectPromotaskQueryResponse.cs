using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskQueryResponse.
    /// </summary>
    public class AlipayMerchantIndirectPromotaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务当前的进度完成值，当任务领取后返回数值
        /// </summary>
        [XmlElement("curent_cnt")]
        public long CurentCnt { get; set; }

        /// <summary>
        /// 任务结束时间，商家领取的任务存在一定的有效期，该时间即为有效期截止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务过期日期 (商户任务报名通过后，生成的任务存在一定的有效期)。当任务领取后才会存在任务过期。
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 任务完成时间，当任务未完成时该字段为空
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 针对统一商户下多个smid账号集合的定义
        /// </summary>
        [XmlElement("group_mid")]
        public string GroupMid { get; set; }

        /// <summary>
        /// 商户权益申领提交时间(商户提报自己的申领账号)
        /// </summary>
        [XmlElement("reward_apply_time")]
        public string RewardApplyTime { get; set; }

        /// <summary>
        /// 活动关联的权益类型编码
        /// </summary>
        [XmlElement("reward_code")]
        public string RewardCode { get; set; }

        /// <summary>
        /// 任务权益的描述介绍
        /// </summary>
        [XmlElement("reward_desc")]
        public string RewardDesc { get; set; }

        /// <summary>
        /// 任务领取时间
        /// </summary>
        [XmlElement("take_time")]
        public string TakeTime { get; set; }

        /// <summary>
        /// 任务目标值
        /// </summary>
        [XmlElement("target_cnt")]
        public long TargetCnt { get; set; }

        /// <summary>
        /// 任务类型编码标识，用以区分不同类型的任务
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 商家在任务报名通过后生成的唯一任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("task_state")]
        public string TaskState { get; set; }
    }
}
