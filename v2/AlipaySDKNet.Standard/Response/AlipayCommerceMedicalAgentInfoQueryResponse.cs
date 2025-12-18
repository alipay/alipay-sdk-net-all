using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAgentInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAgentInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体简介描述
        /// </summary>
        [XmlElement("agent_describe")]
        public string AgentDescribe { get; set; }

        /// <summary>
        /// 智能体id,智能体的唯一标识
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 智能体logo
        /// </summary>
        [XmlElement("agent_logo")]
        public string AgentLogo { get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 智能体状态。 已上线：ALREADY_ONLINE 已下线：OFFLINE_ALREADY
        /// </summary>
        [XmlElement("agent_status")]
        public string AgentStatus { get; set; }

        /// <summary>
        /// 智能体类型。 卫健委：HEALTH_COMMISSION 医院：HOSPITAL 企业：ENTERPRISE 医生：DOCTOR 医保局：MEDICAL_INSURANCE_BUREAU
        /// </summary>
        [XmlElement("agent_type")]
        public string AgentType { get; set; }

        /// <summary>
        /// 市的唯一编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 数字人图片
        /// </summary>
        [XmlElement("digital_human_pic")]
        public string DigitalHumanPic { get; set; }

        /// <summary>
        /// 数字人语音id
        /// </summary>
        [XmlElement("digital_human_voice_id")]
        public string DigitalHumanVoiceId { get; set; }

        /// <summary>
        /// 区的唯一编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 父智能体的agentId.卫健委下的智能体会有值
        /// </summary>
        [XmlElement("parent_agent_id")]
        public string ParentAgentId { get; set; }

        /// <summary>
        /// 省的唯一编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("recommend_question_list")]
        [XmlArrayItem("string")]
        public List<string> RecommendQuestionList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_group_list")]
        [XmlArrayItem("service_group")]
        public List<ServiceGroup> ServiceGroupList { get; set; }

        /// <summary>
        /// 标准机构id
        /// </summary>
        [XmlElement("standard_org_id")]
        public string StandardOrgId { get; set; }

        /// <summary>
        /// 社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }

        /// <summary>
        /// 首页欢迎语
        /// </summary>
        [XmlElement("welcome_desc")]
        public string WelcomeDesc { get; set; }
    }
}
