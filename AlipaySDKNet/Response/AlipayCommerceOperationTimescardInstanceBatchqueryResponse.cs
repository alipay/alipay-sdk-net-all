using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardInstanceBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardInstanceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 卡实例列表
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("time_card_info")]
        public List<TimeCardInfo> Datas { get; set; }

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
