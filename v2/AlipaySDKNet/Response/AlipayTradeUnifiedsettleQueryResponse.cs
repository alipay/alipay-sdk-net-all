using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeUnifiedsettleQueryResponse.
    /// </summary>
    public class AlipayTradeUnifiedsettleQueryResponse : AopResponse
    {
        /// <summary>
        /// 收结易明细列表数据
        /// </summary>
        [XmlArray("order_detail_list")]
        [XmlArrayItem("unified_settle_order_detail")]
        public List<UnifiedSettleOrderDetail> OrderDetailList { get; set; }
    }
}
