using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignCreativeCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignCreativeCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 创意交互动作属性集合，根据接入文档落地页参数配置来补充相关字段
        /// </summary>
        [XmlArray("action_property_list")]
        [XmlArrayItem("creative_action_property")]
        public List<CreativeActionProperty> ActionPropertyList { get; set; }

        /// <summary>
        /// 选择的创意交互动作类型需从接口获取，该字段类型从前置模版配置接口获取当前创意可提交的落地页类型 alipay.data.dataservice.adcampaign.actionandtemplate.query
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 创意ID,新增创意时不填写
        /// </summary>
        [XmlElement("ad_id")]
        public long AdId { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [XmlElement("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 创意点击监测地址S2S
        /// </summary>
        [XmlElement("click_track_url")]
        public string ClickTrackUrl { get; set; }

        /// <summary>
        /// 创意所属单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意曝光监测地址S2S
        /// </summary>
        [XmlElement("impression_track_url")]
        public string ImpressionTrackUrl { get; set; }

        /// <summary>
        /// 组成创意的文案/视频/图片等素材
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("creative_material")]
        public List<CreativeMaterial> MaterialList { get; set; }

        /// <summary>
        /// 委托人标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// true打开/false关闭
        /// </summary>
        [XmlElement("smart_switch")]
        public bool SmartSwitch { get; set; }

        /// <summary>
        /// 创意模版ID，根据前置API获取模版配置 alipay.data.dataservice.adcampaign.actionandtemplate.query
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
