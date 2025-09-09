using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitOrderInfo : AopObject
    {
        /// <summary>
        /// 流水结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 流水业务单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型，非固定值，由业务运营自定义
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlElement("reward_info")]
        public BenefitRewardInfo RewardInfo { get; set; }

        /// <summary>
        /// 权益单列表
        /// </summary>
        [XmlArray("right_order_info_list")]
        [XmlArrayItem("benefit_right_order_info")]
        public List<BenefitRightOrderInfo> RightOrderInfoList { get; set; }

        /// <summary>
        /// 权益业务场景码，非固定值，由业务运营定义
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 流水开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 权益流水业务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 权益业务子场景码，非固定值，由业务运营定义
        /// </summary>
        [XmlElement("sub_scene_code")]
        public string SubSceneCode { get; set; }

        /// <summary>
        /// 权益模板编码，非固定值，由业务运营定义配置
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
