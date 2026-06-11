using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampaignDrawcampTriggerResponse.
    /// </summary>
    public class AlipayCommerceEducateCampaignDrawcampTriggerResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 中奖流水列表
        /// </summary>
        [XmlArray("send_order_list")]
        [XmlArrayItem("edu_mp_prize_send_order")]
        public List<EduMpPrizeSendOrder> SendOrderList { get; set; }

        /// <summary>
        /// 发奖信息
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
