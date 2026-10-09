using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrdermemoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOrdermemoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 订单备注分页记录
        /// </summary>
        [XmlElement("content")]
        public OrderMemoDetail Content { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

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
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
