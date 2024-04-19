using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockOpenPromoReceiveResponse.
    /// </summary>
    public class AntfortuneStockOpenPromoReceiveResponse : AopResponse
    {
        /// <summary>
        /// 奖品发奖明细列表
        /// </summary>
        [XmlArray("prize_receive_detail_list")]
        [XmlArrayItem("prize_receive_detail")]
        public List<PrizeReceiveDetail> PrizeReceiveDetailList { get; set; }
    }
}
