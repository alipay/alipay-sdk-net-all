using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQuerystockoutorderQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffQuerystockoutorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 异常码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 异常描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 出库单
        /// </summary>
        [XmlArray("stock_out_orders")]
        [XmlArrayItem("stuff_stock_out_order")]
        public List<StuffStockOutOrder> StockOutOrders { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
