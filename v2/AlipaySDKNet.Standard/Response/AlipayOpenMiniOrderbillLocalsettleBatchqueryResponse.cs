using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderbillLocalsettleBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderbillLocalsettleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 账单明细列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("local_settle_bill_item")]
        public List<LocalSettleBillItem> BillList { get; set; }

        /// <summary>
        /// 当前分页大小，单位：条目数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页标识，没有下一页时返回空
        /// </summary>
        [XmlElement("page_token")]
        public string PageToken { get; set; }
    }
}
