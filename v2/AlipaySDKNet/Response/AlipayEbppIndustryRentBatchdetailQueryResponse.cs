using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentBatchdetailQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentBatchdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 对账单列表
        /// </summary>
        [XmlArray("bill_detail_list")]
        [XmlArrayItem("rent_pay_query_bill_detail_list_response")]
        public List<RentPayQueryBillDetailListResponse> BillDetailList { get; set; }
    }
}
