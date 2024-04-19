using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeBankRootQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBankRootQueryResponse : AopResponse
    {
        /// <summary>
        /// Institution列表
        /// </summary>
        [XmlArray("bank_details")]
        [XmlArrayItem("institution")]
        public List<Institution> BankDetails { get; set; }
    }
}
