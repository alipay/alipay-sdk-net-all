using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendResponse.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitSendResponse : AopResponse
    {
        /// <summary>
        /// 领取的权益列表
        /// </summary>
        [XmlArray("benefit_ids")]
        [XmlArrayItem("string")]
        public List<string> BenefitIds { get; set; }

        /// <summary>
        /// 发放券展示模型
        /// </summary>
        [XmlArray("voucher_vo_list")]
        [XmlArrayItem("voucher_v_o")]
        public List<VoucherVO> VoucherVoList { get; set; }

        /// <summary>
        /// 发放券展示模型（该字段已废弃）
        /// </summary>
        [XmlElement("voucher_vos")]
        public VoucherVO VoucherVos { get; set; }
    }
}
