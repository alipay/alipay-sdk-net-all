using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockOpenPromoConsultResponse.
    /// </summary>
    public class AntfortuneStockOpenPromoConsultResponse : AopResponse
    {
        /// <summary>
        /// 已领权益集合
        /// </summary>
        [XmlArray("awarded_equity_list")]
        [XmlArrayItem("awarded_equity_v_o")]
        public List<AwardedEquityVO> AwardedEquityList { get; set; }

        /// <summary>
        /// 待领权益集合
        /// </summary>
        [XmlArray("pending_equity_list")]
        [XmlArrayItem("pending_equity_v_o")]
        public List<PendingEquityVO> PendingEquityList { get; set; }
    }
}
