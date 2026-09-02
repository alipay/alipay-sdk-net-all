using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneSimplestPolicyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneSimplestPolicyApplyModel : AopObject
    {
        /// <summary>
        /// 定制参数
        /// </summary>
        [XmlElement("custom_param")]
        public InsOpenSimplestIssueCustomParamDTO CustomParam { get; set; }

        /// <summary>
        /// 保障止期
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保障起期
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 投保人信息
        /// </summary>
        [XmlElement("holder")]
        public InsOpenUserDTO Holder { get; set; }

        /// <summary>
        /// 被保人列表
        /// </summary>
        [XmlArray("insureds")]
        [XmlArrayItem("ins_open_user_d_t_o")]
        public List<InsOpenUserDTO> Insureds { get; set; }

        /// <summary>
        /// 外部业务幂等单号，同 partner_org_id 下唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作伙伴组织ID
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保障期限,示例：1D，表示一天
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 指定产品方案 ID
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
