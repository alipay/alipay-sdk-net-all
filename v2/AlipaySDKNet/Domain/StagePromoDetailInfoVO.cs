using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StagePromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class StagePromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 分期计划详情
        /// </summary>
        [XmlArray("installment_plan_promo_detail_info_list")]
        [XmlArrayItem("installment_plan_promo_detail_info_v_o")]
        public List<InstallmentPlanPromoDetailInfoVO> InstallmentPlanPromoDetailInfoList { get; set; }

        /// <summary>
        /// 阶段编码
        /// </summary>
        [XmlElement("stage_no")]
        public string StageNo { get; set; }
    }
}
