using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品数据列表
        /// </summary>
        [XmlElement("datas")]
        public TimeCardItemInfo Datas { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页size
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
