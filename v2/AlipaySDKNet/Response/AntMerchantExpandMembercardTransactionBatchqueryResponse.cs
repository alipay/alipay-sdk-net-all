using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardTransactionBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandMembercardTransactionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商家会员交易明细列表
        /// </summary>
        [XmlArray("transaction_detail_list")]
        [XmlArrayItem("member_card_user_transaction_detail")]
        public List<MemberCardUserTransactionDetail> TransactionDetailList { get; set; }
    }
}
