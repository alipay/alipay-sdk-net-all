using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfBilldetailQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfBilldetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单明细集合
        /// </summary>
        [XmlArray("billdetailresultlist")]
        [XmlArrayItem("bill_detail_result")]
        public List<BillDetailResult> Billdetailresultlist { get; set; }

        /// <summary>
        /// 当前页码1
        /// </summary>
        [XmlElement("pageindex")]
        public long Pageindex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("pagesize")]
        public long Pagesize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("totalnums")]
        public long Totalnums { get; set; }
    }
}
