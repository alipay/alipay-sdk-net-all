using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingRtaConsultResponse.
    /// </summary>
    public class AnttechMorseMarketingRtaConsultResponse : AopResponse
    {
        /// <summary>
        /// 查询准入标识本次查询准入结果，true|false，true代表可以准入，false代表不准入或不在服务人群
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于问题定位
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 活动奖品信息，list对象，描述用户命中活动后能享有的奖品信息，包含活动id、渠道信息、创意信息和权益信息，只有命中的情况下必选
        /// </summary>
        [XmlArray("campaign_prize")]
        [XmlArrayItem("campaign_prize")]
        public List<CampaignPrize> CampaignPrize { get; set; }
    }
}
