using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandShopBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 线下门店的列表;有可能为空
        /// </summary>
        [XmlArray("shops")]
        [XmlArrayItem("simple_shop_info")]
        public List<SimpleShopInfo> Shops { get; set; }

        /// <summary>
        /// 按照分页数量拆分，分解出来的页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 所有线下门店数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
