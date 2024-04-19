using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantIndirectPromotaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 任务列表，存储符合查询条件的任务对象
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("indirect_promo_task")]
        public List<IndirectPromoTask> ItemList { get; set; }

        /// <summary>
        /// 符合查询条件的数据总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
