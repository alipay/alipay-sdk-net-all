using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShopAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceEcShopAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("trade_identity_list")]
        [XmlArrayItem("ec_trade_identity_account_info")]
        public List<EcTradeIdentityAccountInfo> TradeIdentityList { get; set; }
    }
}
