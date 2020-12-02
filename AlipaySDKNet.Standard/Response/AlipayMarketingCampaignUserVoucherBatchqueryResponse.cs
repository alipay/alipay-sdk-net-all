using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当面页数
        /// </summary>
        [XmlElement("current_pages")]
        public string CurrentPages { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 返回总条目数
        /// </summary>
        [XmlElement("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 券详情列表
        /// </summary>
        [XmlArray("voucher_item_list")]
        [XmlArrayItem("voucher_item")]
        public List<VoucherItem> VoucherItemList { get; set; }
    }
}
