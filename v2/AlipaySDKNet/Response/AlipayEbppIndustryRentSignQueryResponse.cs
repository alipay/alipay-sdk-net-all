using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentSignQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentSignQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sign_info_list")]
        [XmlArrayItem("rent_pay_query_user_sign_info_response")]
        public List<RentPayQueryUserSignInfoResponse> SignInfoList { get; set; }
    }
}
