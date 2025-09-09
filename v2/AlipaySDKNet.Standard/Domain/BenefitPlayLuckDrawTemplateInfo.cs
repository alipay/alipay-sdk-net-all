using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitPlayLuckDrawTemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitPlayLuckDrawTemplateInfo : AopObject
    {
        /// <summary>
        /// 玩法模板编码。非固定值，由业务运营定义
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 玩法展示信息
        /// </summary>
        [XmlElement("display_info")]
        public BenefitTemplateDisplayInfo DisplayInfo { get; set; }

        /// <summary>
        /// 模板结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 权益模板优先级，衡量权益权重。无度量单位，数值越大，权重越大。
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 奖品模型信息
        /// </summary>
        [XmlElement("reward_info")]
        public BenefitRewardInfo RewardInfo { get; set; }

        /// <summary>
        /// 权益模板业务场景码。非固定值，由业务运营配置
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 模板开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 具体玩法模板状态，非错误码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 权益模板业务子场景码。非固定值，由业务运营配置
        /// </summary>
        [XmlElement("sub_scene_code")]
        public string SubSceneCode { get; set; }
    }
}
