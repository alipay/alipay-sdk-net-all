using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEcomdetailPersonQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEcomdetailPersonQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("array_data")]
        [XmlArrayItem("ecom_company_info")]
        public List<EcomCompanyInfo> ArrayData { get; set; }
    }
}
