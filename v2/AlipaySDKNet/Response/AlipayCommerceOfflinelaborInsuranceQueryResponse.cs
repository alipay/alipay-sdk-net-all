using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceQueryResponse.
    /// </summary>
    public class AlipayCommerceOfflinelaborInsuranceQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("policys")]
        [XmlArrayItem("offline_labor_insurance_policy")]
        public List<OfflineLaborInsurancePolicy> Policys { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
