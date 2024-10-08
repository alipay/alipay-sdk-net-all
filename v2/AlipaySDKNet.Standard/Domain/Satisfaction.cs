using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Satisfaction Data Structure.
    /// </summary>
    [Serializable]
    public class Satisfaction : AopObject
    {
        /// <summary>
        /// 客服2088id
        /// </summary>
        [XmlElement("agent_alipay_uid")]
        public string AgentAlipayUid { get; set; }

        /// <summary>
        /// 客服生命周期
        /// </summary>
        [XmlElement("agent_new_old_type")]
        public string AgentNewOldType { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        [XmlElement("agent_nickname")]
        public string AgentNickname { get; set; }

        /// <summary>
        /// 客服名
        /// </summary>
        [XmlElement("agent_real_name")]
        public string AgentRealName { get; set; }

        /// <summary>
        /// 客服技能组
        /// </summary>
        [XmlElement("agent_skill_group")]
        public string AgentSkillGroup { get; set; }

        /// <summary>
        /// 智能助手答案有用吗得分（分）
        /// </summary>
        [XmlElement("ai_assistant_score")]
        public string AiAssistantScore { get; set; }

        /// <summary>
        /// 评价触发id
        /// </summary>
        [XmlElement("appraise_id")]
        public string AppraiseId { get; set; }

        /// <summary>
        /// 评价问题数（个）
        /// </summary>
        [XmlElement("appraise_question_cnt")]
        public string AppraiseQuestionCnt { get; set; }

        /// <summary>
        /// 评价结果分类内容
        /// </summary>
        [XmlElement("appraise_result")]
        public string AppraiseResult { get; set; }

        /// <summary>
        /// 评价触发时间，非固定某一天
        /// </summary>
        [XmlElement("appraise_trigger_time")]
        public string AppraiseTriggerTime { get; set; }

        /// <summary>
        /// 评价触发类型名称
        /// </summary>
        [XmlElement("appraise_type_name")]
        public string AppraiseTypeName { get; set; }

        /// <summary>
        /// 均响时长（秒）
        /// </summary>
        [XmlElement("avg_response_length")]
        public string AvgResponseLength { get; set; }

        /// <summary>
        /// 业务线名称
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// 二级业务线
        /// </summary>
        [XmlElement("business_name_level_2")]
        public string BusinessNameLevel2 { get; set; }

        /// <summary>
        /// 进线渠道
        /// </summary>
        [XmlElement("call_in_user_type")]
        public string CallInUserType { get; set; }

        /// <summary>
        /// 一级类目
        /// </summary>
        [XmlElement("cat_name_level_1")]
        public string CatNameLevel1 { get; set; }

        /// <summary>
        /// 二级类目
        /// </summary>
        [XmlElement("cat_name_level_2")]
        public string CatNameLevel2 { get; set; }

        /// <summary>
        /// 三级类目
        /// </summary>
        [XmlElement("cat_name_level_3")]
        public string CatNameLevel3 { get; set; }

        /// <summary>
        /// 结案时长（秒）
        /// </summary>
        [XmlElement("close_case_length")]
        public string CloseCaseLength { get; set; }

        /// <summary>
        /// 关单类型
        /// </summary>
        [XmlElement("close_ticket_type")]
        public string CloseTicketType { get; set; }

        /// <summary>
        /// 服务入口容易找到吗得分(分)
        /// </summary>
        [XmlElement("entry_difficulty_score")]
        public string EntryDifficultyScore { get; set; }

        /// <summary>
        /// 首响时长（秒）
        /// </summary>
        [XmlElement("first_response_length")]
        public string FirstResponseLength { get; set; }

        /// <summary>
        /// 客服理解您的问题吗得分(分)
        /// </summary>
        [XmlElement("grasp_score")]
        public string GraspScore { get; set; }

        /// <summary>
        /// 是否中途断线
        /// </summary>
        [XmlElement("is_discontinue")]
        public string IsDiscontinue { get; set; }

        /// <summary>
        /// 是否解决
        /// </summary>
        [XmlElement("is_solved")]
        public string IsSolved { get; set; }

        /// <summary>
        /// 是否提交评价
        /// </summary>
        [XmlElement("is_submitted")]
        public string IsSubmitted { get; set; }

        /// <summary>
        /// 人工客服容易找到吗得分（分）
        /// </summary>
        [XmlElement("manual_service_score")]
        public string ManualServiceScore { get; set; }

        /// <summary>
        /// 关联订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务请求id蚂蚁
        /// </summary>
        [XmlElement("origin_session_id_ant")]
        public string OriginSessionIdAnt { get; set; }

        /// <summary>
        /// 客户其它建议
        /// </summary>
        [XmlElement("other_adv")]
        public string OtherAdv { get; set; }

        /// <summary>
        /// 总评分（分）
        /// </summary>
        [XmlElement("overall_score")]
        public string OverallScore { get; set; }

        /// <summary>
        /// 客服处理速度够快吗得分(分)
        /// </summary>
        [XmlElement("process_speed_score")]
        public string ProcessSpeedScore { get; set; }

        /// <summary>
        /// 排队时长（秒）
        /// </summary>
        [XmlElement("queue_length")]
        public string QueueLength { get; set; }

        /// <summary>
        /// 统计日期,非固定某一天
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 自助查询问题方便吗得分（分）
        /// </summary>
        [XmlElement("self_service_score")]
        public string SelfServiceScore { get; set; }

        /// <summary>
        /// 客服服务态度满意吗得分（分）
        /// </summary>
        [XmlElement("service_attitude_score")]
        public string ServiceAttitudeScore { get; set; }

        /// <summary>
        /// 传递的渠道
        /// </summary>
        [XmlElement("service_channel")]
        public string ServiceChannel { get; set; }

        /// <summary>
        /// 会话id蚂蚁
        /// </summary>
        [XmlElement("session_id_ant")]
        public string SessionIdAnt { get; set; }

        /// <summary>
        /// 会话id哈啰
        /// </summary>
        [XmlElement("session_id_hello")]
        public string SessionIdHello { get; set; }

        /// <summary>
        /// 会话状态
        /// </summary>
        [XmlElement("session_type")]
        public string SessionType { get; set; }

        /// <summary>
        /// 客服解决方案满意吗得分(分)
        /// </summary>
        [XmlElement("solution_score")]
        public string SolutionScore { get; set; }

        /// <summary>
        /// 渠道细分
        /// </summary>
        [XmlElement("sub_channel")]
        public string SubChannel { get; set; }

        /// <summary>
        /// 客户guid
        /// </summary>
        [XmlElement("user_guid")]
        public string UserGuid { get; set; }

        /// <summary>
        /// 客户联系方式
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
