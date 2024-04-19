using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletOperationQueryResponse.
    /// </summary>
    public class AlipayFundWalletOperationQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// ["walletOperation":"11"]
        /// </summary>
        [XmlArray("wallet_operations")]
        [XmlArrayItem("wallet_operation")]
        public List<WalletOperation> WalletOperations { get; set; }
    }
}
