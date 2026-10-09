using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseFollowupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerOpenbaseFollowupCreateModel : AopObject
    {
        /// <summary>
        /// 候选人姓名
        /// </summary>
        [XmlElement("candidate_name")]
        public string CandidateName { get; set; }

        /// <summary>
        /// 候选人手机号
        /// </summary>
        [XmlElement("candidate_phone")]
        public string CandidatePhone { get; set; }

        /// <summary>
        /// 场景变量,Map<String,String>,键值均为 String,必含键:ORDER_NO 客户侧订单号(供话术引用与业务关联)、COMPANY 企业名称、WORK_LOCATION 工作地点、JOB_TITLE 岗位名称(均话术变量);WORK_TIME 上工时间(时间基准变量,计算首次触达基准;ISO 8601;未声明或未传时尽快执行,仍受频控与呼叫时段限制);CANDIDATE_NAME 候选人姓名(话术称呼,缺则创建拒绝);CANDIDATE_PHONE 候选人手机号(外呼目标,随整报文加密传输,明文不单独字段级加密,解密后平台外呼与同号频控,接入层透传不解析);TASK_DEADLINE 任务绝对截止时间(ISO 8601,须晚于当前且不超过创建后 30 天,超则创建失败;到点未果→任务以「结果获取超时」WAIT_TIMEOUT 结束并回告);STAGE_KEY 跟进环节标识(枚举 ARRIVAL_CONFIRMATION 上工履约 / SETTLEMENT_REMINDER 催结算提醒)。
        /// </summary>
        [XmlElement("context")]
        public FollowupCreateContext Context { get; set; }

        /// <summary>
        /// 任务截止时间
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 客户业务单号,appId 下唯一,作为创建幂等键;1~64 位英文字母与数字(纯数字可用、不强制),勿用下划线等符号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 线下提供的可用方案 ID。
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
