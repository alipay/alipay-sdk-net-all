using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserActivityvoucherBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserActivityvoucherBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动券列表
        /// </summary>
        [XmlArray("activity_voucher_list")]
        [XmlArrayItem("activity_voucher_info")]
        public List<ActivityVoucherInfo> ActivityVoucherList { get; set; }
    }
}
