using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampConsultResponse : AopResponse
    {
        /// <summary>
        /// 营销海豚活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 咨询错误码：为空时表示活动咨询正常，不为空时表示活动咨询失败。
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 咨询错误码描述：为空时表示活动咨询正常，不为空时表示活动咨询失败
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 咨询有效的奖品列表，是一个ArrayList
        /// </summary>
        [XmlArray("valid_prize_infos")]
        [XmlArrayItem("kn_prize_info")]
        public List<KnPrizeInfo> ValidPrizeInfos { get; set; }
    }
}
