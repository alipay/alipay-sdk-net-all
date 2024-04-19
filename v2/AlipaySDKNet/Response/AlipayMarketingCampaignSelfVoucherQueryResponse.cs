using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfVoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 券列表
        /// </summary>
        [XmlElement("voucher_item")]
        public VoucherItem VoucherItem { get; set; }
    }
}
