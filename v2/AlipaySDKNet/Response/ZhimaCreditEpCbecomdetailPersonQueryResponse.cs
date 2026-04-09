using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCbecomdetailPersonQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCbecomdetailPersonQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("array_data")]
        [XmlArrayItem("cross_border_ecom_company_detail")]
        public List<CrossBorderEcomCompanyDetail> ArrayData { get; set; }
    }
}
