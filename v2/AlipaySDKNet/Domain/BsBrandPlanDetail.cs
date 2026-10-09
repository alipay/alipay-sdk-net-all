using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsBrandPlanDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BsBrandPlanDetail : AopObject
    {
        /// <summary>
        /// 计划发起方的品牌信息
        /// </summary>
        [XmlElement("brand_info")]
        public BsPlanBrandInfo BrandInfo { get; set; }

        /// <summary>
        /// 联营计划介绍
        /// </summary>
        [XmlElement("intro")]
        public BsBrandPlanIntro Intro { get; set; }

        /// <summary>
        /// 计划邀约配置
        /// </summary>
        [XmlElement("invite_config")]
        public BsPlanInviteConfig InviteConfig { get; set; }

        /// <summary>
        /// 联营计划ID,在计划管理平台查看
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 联营方案类型，如EASY_BUY：顺手买
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
