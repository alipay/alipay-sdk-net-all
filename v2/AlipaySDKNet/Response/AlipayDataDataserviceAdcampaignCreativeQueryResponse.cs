using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignCreativeQueryResponse : AopResponse
    {
        /// <summary>
        /// 交互动作属性集合
        /// </summary>
        [XmlArray("action_property_list")]
        [XmlArrayItem("creative_action_property")]
        public List<CreativeActionProperty> ActionPropertyList { get; set; }

        /// <summary>
        /// 选择的创意交互动作方式，该字段类型说明可参考对客接口文档落地页部分
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

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
        /// 创意拒绝理由文案信息，由审核方填充
        /// </summary>
        [XmlElement("audit_refuse_reason")]
        public string AuditRefuseReason { get; set; }

        /// <summary>
        /// 创意点击监测地址
        /// </summary>
        [XmlElement("click_track_url")]
        public string ClickTrackUrl { get; set; }

        /// <summary>
        /// 创意业务状态
        /// </summary>
        [XmlElement("creative_biz_status")]
        public string CreativeBizStatus { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 所属单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 所属单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 创意曝光监测地址
        /// </summary>
        [XmlElement("impression_track_url")]
        public string ImpressionTrackUrl { get; set; }

        /// <summary>
        /// 二级营销目标
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 二级营销目标名称
        /// </summary>
        [XmlElement("market_target_name")]
        public string MarketTargetName { get; set; }

        /// <summary>
        /// 组成创意的文案/视频/图片等素材
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("creative_material")]
        public List<CreativeMaterial> MaterialList { get; set; }

        /// <summary>
        /// 所属计划id
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
        /// 审核拒绝扩展信息
        /// </summary>
        [XmlElement("refuse_extend_info_res")]
        public CreativeRefuseExtendInfoRes RefuseExtendInfoRes { get; set; }

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
        /// true打开/false关闭
        /// </summary>
        [XmlElement("smart_switch")]
        public bool SmartSwitch { get; set; }

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
