using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletOperationQueryResponse.
    /// </summary>
    public class AlipayCloudFundWalletOperationQueryResponse : AopResponse
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
        /// 钱包操作明细
        /// </summary>
        [XmlElement("wallet_operations")]
        public WalletOperationDetails WalletOperations { get; set; }
    }
}
