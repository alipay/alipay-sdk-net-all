using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletExternalaccountConsultResponse.
    /// </summary>
    public class AlipayFundWalletExternalaccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 外部账户
        /// </summary>
        [XmlElement("wallet_external_accounts")]
        public WalletExternalAccount WalletExternalAccounts { get; set; }
    }
}
