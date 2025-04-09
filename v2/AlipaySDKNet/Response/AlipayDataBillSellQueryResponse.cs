using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillSellQueryResponse.
    /// </summary>
    public class AlipayDataBillSellQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易流水详情，如果不存在记录则为空
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("trade_item_result")]
        public List<TradeItemResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
