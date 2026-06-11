using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletPageoperationQueryResponse.
    /// </summary>
    public class AlipayFundWalletPageoperationQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务单据列表
        /// </summary>
        [XmlArray("fund_wallet_biz_order_response_list")]
        [XmlArrayItem("fund_wallet_biz_order_response")]
        public List<FundWalletBizOrderResponse> FundWalletBizOrderResponseList { get; set; }
    }
}
