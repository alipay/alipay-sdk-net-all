using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentBillQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentBillQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("user_bill_list")]
        [XmlArrayItem("rent_pay_query_bill_info_response")]
        public List<RentPayQueryBillInfoResponse> UserBillList { get; set; }
    }
}
