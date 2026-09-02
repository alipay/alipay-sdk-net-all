using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsVoicePlanQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsVoicePlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务日期（幂等键）
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 计划生效结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 投放计划ID
        /// </summary>
        [XmlElement("logistics_voice_plan_id")]
        public string LogisticsVoicePlanId { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 计划状态
        /// </summary>
        [XmlElement("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 失败SN数量（SAVING状态时可能为空）
        /// </summary>
        [XmlElement("sn_fail_count")]
        public long SnFailCount { get; set; }

        /// <summary>
        /// 成功SN数量（SAVING状态时可能为空）
        /// </summary>
        [XmlElement("sn_success_count")]
        public long SnSuccessCount { get; set; }

        /// <summary>
        /// SN总数（SAVING状态时可能为空）
        /// </summary>
        [XmlElement("sn_total_count")]
        public long SnTotalCount { get; set; }

        /// <summary>
        /// 计划生效开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 语音模板ID
        /// </summary>
        [XmlElement("voice_template_id")]
        public string VoiceTemplateId { get; set; }
    }
}
