using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationPromokernelPrizeReceiveResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationPromokernelPrizeReceiveResponse : AopResponse
    {
        /// <summary>
        /// 活动单据信息
        /// </summary>
        [XmlElement("camp_order_info")]
        public CampOrderInfo CampOrderInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("prize_send_order_detail_list")]
        [XmlArrayItem("prize_send_order_detail_res")]
        public List<PrizeSendOrderDetailRes> PrizeSendOrderDetailList { get; set; }
    }
}
