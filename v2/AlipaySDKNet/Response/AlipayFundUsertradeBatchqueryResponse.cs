using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundUsertradeBatchqueryResponse.
    /// </summary>
    public class AlipayFundUsertradeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 拉取的结束时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 入参中的分页页码
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 入参中的分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 拉取的起始时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交易时间区间内的总交易数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 用户交易数据
        /// </summary>
        [XmlArray("trade_info_list")]
        [XmlArrayItem("user_trade_info_d_t_o")]
        public List<UserTradeInfoDTO> TradeInfoList { get; set; }
    }
}
