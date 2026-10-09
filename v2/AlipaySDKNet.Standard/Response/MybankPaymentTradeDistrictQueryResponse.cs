using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeDistrictQueryResponse.
    /// </summary>
    public class MybankPaymentTradeDistrictQueryResponse : AopResponse
    {
        /// <summary>
        /// District列表
        /// </summary>
        [XmlArray("district_details")]
        [XmlArrayItem("district")]
        public List<District> DistrictDetails { get; set; }
    }
}
