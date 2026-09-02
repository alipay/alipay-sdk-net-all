using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsBillQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationBsBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单明细列表
        /// </summary>
        [XmlArray("bill_details")]
        [XmlArrayItem("bs_bill_detail")]
        public List<BsBillDetail> BillDetails { get; set; }

        /// <summary>
        /// 下一次查询需要回传的游标。为空表示没有下一页
        /// </summary>
        [XmlElement("next_cursor")]
        public string NextCursor { get; set; }

        /// <summary>
        /// 满足查询条件的总条数。仅首次查询且 `need_count=true` 时返回
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
