using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingConsultResponse.
    /// </summary>
    public class AlipayVoyagerMarketingConsultResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("available_benefit_list")]
        [XmlArrayItem("benefit_display_v_o")]
        public List<BenefitDisplayVO> AvailableBenefitList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("best_benefit_list")]
        [XmlArrayItem("benefit_display_v_o")]
        public List<BenefitDisplayVO> BestBenefitList { get; set; }

        /// <summary>
        /// 价格信息（订单维度价格计算结果透传）
        /// </summary>
        [XmlElement("price_info_dto")]
        public VoyagerPriceInfoDTO PriceInfoDto { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }

        /// <summary>
        /// 传入的 voucherIds 对应券是否都可用（未传 voucherIds 时为 null；false 时 bestBenefitList 已兜底最优券）
        /// </summary>
        [XmlElement("selected_voucher_available")]
        public bool SelectedVoucherAvailable { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("un_available_benefit_list")]
        [XmlArrayItem("benefit_display_v_o")]
        public List<BenefitDisplayVO> UnAvailableBenefitList { get; set; }
    }
}
