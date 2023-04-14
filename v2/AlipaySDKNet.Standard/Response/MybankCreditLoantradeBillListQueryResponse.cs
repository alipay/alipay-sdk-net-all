using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeBillListQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeBillListQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单详细信息
        /// </summary>
        [XmlElement("bill_detail_list")]
        public BillDetailVo BillDetailList { get; set; }

        /// <summary>
        /// 是否有下一页，false表示已经到最后一页了
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前页面条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [XmlElement("refuse_msg")]
        public RefuseVo RefuseMsg { get; set; }

        /// <summary>
        /// 标识本次请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
