using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativePageListRes Data Structure.
    /// </summary>
    [Serializable]
    public class CreativePageListRes : AopObject
    {
        /// <summary>
        /// 创意id
        /// </summary>
        [XmlElement("ad_id")]
        public long AdId { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [XmlElement("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 创意业务状态 PARTIALLY_ENABLE 代表有效-部分审核不通过状态
        /// </summary>
        [XmlElement("creative_biz_status")]
        public string CreativeBizStatus { get; set; }

        /// <summary>
        /// 创意模版
        /// </summary>
        [XmlElement("creative_type")]
        public string CreativeType { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 二级营销目标code
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 二级营销目标名称
        /// </summary>
        [XmlElement("market_target_name")]
        public string MarketTargetName { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 处置理由
        /// </summary>
        [XmlElement("punish_reason")]
        public string PunishReason { get; set; }

        /// <summary>
        /// 创意处置。状态 0:正常,1:风控
        /// </summary>
        [XmlElement("risk_status")]
        public string RiskStatus { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 创意状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 创意模板ID
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
