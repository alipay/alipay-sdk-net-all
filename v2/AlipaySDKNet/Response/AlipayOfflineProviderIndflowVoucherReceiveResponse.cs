using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderIndflowVoucherReceiveResponse.
    /// </summary>
    public class AlipayOfflineProviderIndflowVoucherReceiveResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("prize_details")]
        [XmlArrayItem("ad_voucher_prize_detail")]
        public List<AdVoucherPrizeDetail> PrizeDetails { get; set; }
    }
}
