using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletBalancedetailsQueryResponse.
    /// </summary>
    public class AntMerchantMemberwalletBalancedetailsQueryResponse : AopResponse
    {
        /// <summary>
        /// 余额变更明细
        /// </summary>
        [XmlArray("balance_detail_list")]
        [XmlArrayItem("member_wallet_balance_detail_v_o")]
        public List<MemberWalletBalanceDetailVO> BalanceDetailList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页长
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("row_count")]
        public long RowCount { get; set; }
    }
}
