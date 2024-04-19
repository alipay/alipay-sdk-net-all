using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyTradedetaillistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyTradedetaillistQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易明细
        /// </summary>
        [XmlArray("devicetradedetaillist")]
        [XmlArrayItem("device_trade_detail")]
        public List<DeviceTradeDetail> Devicetradedetaillist { get; set; }

        /// <summary>
        /// 表示记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
