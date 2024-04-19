using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVoucherTransferdetailQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherTransferdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 券交易明细
        /// </summary>
        [XmlArray("open_voucher_trade_fund_details")]
        [XmlArrayItem("open_voucher_trade_fund_detail")]
        public List<OpenVoucherTradeFundDetail> OpenVoucherTradeFundDetails { get; set; }
    }
}
