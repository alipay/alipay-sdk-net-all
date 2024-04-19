using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantTradecomplainBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantTradecomplainBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        [XmlElement("total_page_num")]
        public long TotalPageNum { get; set; }

        /// <summary>
        /// 交易纠纷工单列表信息
        /// </summary>
        [XmlArray("trade_complain_infos")]
        [XmlArrayItem("trade_complain_query_response")]
        public List<TradeComplainQueryResponse> TradeComplainInfos { get; set; }
    }
}
