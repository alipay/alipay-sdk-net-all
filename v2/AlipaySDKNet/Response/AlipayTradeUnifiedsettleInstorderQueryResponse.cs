using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeUnifiedsettleInstorderQueryResponse.
    /// </summary>
    public class AlipayTradeUnifiedsettleInstorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回true表示可以调整时间范围继续搜索更多数据
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 明细信息列表
        /// </summary>
        [XmlArray("order_info_list")]
        [XmlArrayItem("unified_settle_trade_inst_order_info")]
        public List<UnifiedSettleTradeInstOrderInfo> OrderInfoList { get; set; }
    }
}
