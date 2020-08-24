using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsSceneTaskFlowDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsSceneTaskFlowDTO : AopObject
    {
        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extra_map")]
        public string ExtraMap { get; set; }

        /// <summary>
        /// 任务流水完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 营销任务流水的更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 活动参与id
        /// </summary>
        [XmlElement("join_id")]
        public string JoinId { get; set; }

        /// <summary>
        /// 营销场景码
        /// </summary>
        [XmlElement("marketing_scene")]
        public string MarketingScene { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 被参与活动的用户id
        /// </summary>
        [XmlElement("participant_user_id")]
        public string ParticipantUserId { get; set; }

        /// <summary>
        /// 参与活动的用户id
        /// </summary>
        [XmlElement("participator_user_id")]
        public string ParticipatorUserId { get; set; }

        /// <summary>
        /// 领取时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 任务流水状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 任务流水号
        /// </summary>
        [XmlElement("task_flowid")]
        public string TaskFlowid { get; set; }

        /// <summary>
        /// 添加状态查询
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
