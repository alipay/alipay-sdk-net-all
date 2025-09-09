using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentStagePromoDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentStagePromoDetailInfoVO : AopObject
    {
        /// <summary>
        /// 分期计划详情
        /// </summary>
        [XmlArray("installment_plan_promo_detail_info_list")]
        [XmlArrayItem("rent_installment_plan_promo_detail_info_v_o")]
        public List<RentInstallmentPlanPromoDetailInfoVO> InstallmentPlanPromoDetailInfoList { get; set; }

        /// <summary>
        /// 阶段编码
        /// </summary>
        [XmlElement("stage_no")]
        public string StageNo { get; set; }
    }
}
