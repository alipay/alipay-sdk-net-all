using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceServiceproductPageQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceServiceproductPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务产品列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("service_product_info")]
        public List<ServiceProductInfo> Items { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
