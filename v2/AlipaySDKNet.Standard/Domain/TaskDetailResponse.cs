using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TaskDetailResponse : AopObject
    {
        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_open_id")]
        public string CreatorOpenId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 奖品信息返回值
        /// </summary>
        [XmlElement("prize_response")]
        public PrizeResponse PrizeResponse { get; set; }

        /// <summary>
        /// 二级商户appid
        /// </summary>
        [XmlElement("second_merchant_appid")]
        public string SecondMerchantAppid { get; set; }

        /// <summary>
        /// 任务条件
        /// </summary>
        [XmlElement("task_condition")]
        public string TaskCondition { get; set; }

        /// <summary>
        /// 任务合约周期(单位是月)
        /// </summary>
        [XmlElement("task_contract_period")]
        public string TaskContractPeriod { get; set; }

        /// <summary>
        /// 任务有效期结束
        /// </summary>
        [XmlElement("task_end")]
        public string TaskEnd { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 参与任务的用户数量
        /// </summary>
        [XmlElement("task_join_count")]
        public long TaskJoinCount { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务有效期-开始
        /// </summary>
        [XmlElement("task_start")]
        public string TaskStart { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [XmlElement("task_title")]
        public string TaskTitle { get; set; }
    }
}
