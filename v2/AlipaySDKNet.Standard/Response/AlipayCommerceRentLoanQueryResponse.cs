using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentLoanQueryResponse.
    /// </summary>
    public class AlipayCommerceRentLoanQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("consult_result_infos")]
        [XmlArrayItem("rent_loan_consult_result")]
        public List<RentLoanConsultResult> ConsultResultInfos { get; set; }
    }
}
