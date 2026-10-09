using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletFundhistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletFundhistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 充值记录列表
        /// </summary>
        [XmlArray("fund_histories")]
        [XmlArrayItem("fund_history")]
        public List<FundHistory> FundHistories { get; set; }
    }
}
