using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsTokenWaybillQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsTokenWaybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 寄件信息
        /// </summary>
        [XmlArray("match_waybill_list")]
        [XmlArrayItem("waybill_match_info_obj")]
        public List<WaybillMatchInfoObj> MatchWaybillList { get; set; }
    }
}
