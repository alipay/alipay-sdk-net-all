using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeAccountFundcompositionQueryResponse.
    /// </summary>
    public class AlipayTradeAccountFundcompositionQueryResponse : AopResponse
    {
        /// <summary>
        /// 专户账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行专户的转入资金明细
        /// </summary>
        [XmlArray("card_amount_detail_list")]
        [XmlArrayItem("card_amount_detail_v_o")]
        public List<CardAmountDetailVO> CardAmountDetailList { get; set; }
    }
}
