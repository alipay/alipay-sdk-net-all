using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentBillbatchQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentBillbatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单批次列表
        /// </summary>
        [XmlArray("batch_list")]
        [XmlArrayItem("rent_pay_query_bill_list_response")]
        public List<RentPayQueryBillListResponse> BatchList { get; set; }

        /// <summary>
        /// 账单总金额，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
