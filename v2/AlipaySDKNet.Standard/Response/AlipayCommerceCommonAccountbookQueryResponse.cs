using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonAccountbookQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonAccountbookQueryResponse : AopResponse
    {
        /// <summary>
        /// 账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 账本信息
        /// </summary>
        [XmlArray("account_book_info")]
        [XmlArrayItem("fund_account_book_info_d_t_o")]
        public List<FundAccountBookInfoDTO> AccountBookInfo { get; set; }

        /// <summary>
        /// 账户可用余额，单位元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 外卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总数据数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
