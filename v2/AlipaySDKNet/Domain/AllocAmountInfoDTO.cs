using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AllocAmountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AllocAmountInfoDTO : AopObject
    {
        /// <summary>
        /// 买断分账计划
        /// </summary>
        [XmlElement("buy_out_royalty")]
        public RoyaltyDTO BuyOutRoyalty { get; set; }

        /// <summary>
        /// 用于资方明确指定app时使用
        /// </summary>
        [XmlElement("invest_app_id")]
        public string InvestAppId { get; set; }

        /// <summary>
        /// 资方PID，对应合作融资的资方pid
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 租金分账明细
        /// </summary>
        [XmlArray("rent_royalty_details")]
        [XmlArrayItem("rent_royalty_detail_d_t_o")]
        public List<RentRoyaltyDetailDTO> RentRoyaltyDetails { get; set; }
    }
}
