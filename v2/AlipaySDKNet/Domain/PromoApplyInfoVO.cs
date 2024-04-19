using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoApplyInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoApplyInfoVO : AopObject
    {
        /// <summary>
        /// 营销申领商品明细列表
        /// </summary>
        [XmlArray("promo_apply_item_infos")]
        [XmlArrayItem("promo_apply_item_info_v_o")]
        public List<PromoApplyItemInfoVO> PromoApplyItemInfos { get; set; }

        /// <summary>
        /// 营销申领汇总列表
        /// </summary>
        [XmlArray("promo_apply_summary_infos")]
        [XmlArrayItem("promo_apply_summary_info_v_o")]
        public List<PromoApplySummaryInfoVO> PromoApplySummaryInfos { get; set; }
    }
}
