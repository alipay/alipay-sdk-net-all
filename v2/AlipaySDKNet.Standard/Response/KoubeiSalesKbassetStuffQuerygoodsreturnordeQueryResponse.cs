using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQuerygoodsreturnordeQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffQuerygoodsreturnordeQueryResponse : AopResponse
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
        /// 退货单
        /// </summary>
        [XmlArray("goods_return_orders")]
        [XmlArrayItem("goods_return_order")]
        public List<GoodsReturnOrder> GoodsReturnOrders { get; set; }

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
        /// 本次调用是否成功
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
