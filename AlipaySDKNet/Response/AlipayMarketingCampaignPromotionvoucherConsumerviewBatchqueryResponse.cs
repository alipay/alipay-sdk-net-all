using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 券详情列表
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("voucher_detail_v_o")]
        public List<VoucherDetailVO> Vouchers { get; set; }
    }
}
