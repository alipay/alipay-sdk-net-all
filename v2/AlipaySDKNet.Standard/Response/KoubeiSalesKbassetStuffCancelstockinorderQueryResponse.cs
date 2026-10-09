using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffCancelstockinorderQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffCancelstockinorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 待取消的入库单号
        /// </summary>
        [XmlArray("erp_orders")]
        [XmlArrayItem("string")]
        public List<string> ErpOrders { get; set; }

        /// <summary>
        /// 异常码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 报错描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 扩展字段，保留
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 分页查询当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询每页数据量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 查询数据总量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
