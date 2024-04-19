using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectPromoTask Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectPromoTask : AopObject
    {
        /// <summary>
        /// 任务当前完成进度值
        /// </summary>
        [XmlElement("curent_cnt")]
        public long CurentCnt { get; set; }

        /// <summary>
        /// 任务结束时间，商家领取的任务存在一定的有效期，该时间即为有效期截止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务过期日期 (商户任务报名通过后，生成的任务存在一定的有效期)
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 任务完成时间。标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 商户账号组ID，平台侧对同一商户下多个smid账号的结合定义
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
        /// 商户完成任务后获得的权益描述介绍
        /// </summary>
        [XmlElement("reward_desc")]
        public string RewardDesc { get; set; }

        /// <summary>
        /// 服务商账号对应的2088
        /// </summary>
        [XmlElement("source_pid")]
        public string SourcePid { get; set; }

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
        /// 营销任务编码，用以区分任务类型
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 营销任务ID，用以区分商户领取的任务实例
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
