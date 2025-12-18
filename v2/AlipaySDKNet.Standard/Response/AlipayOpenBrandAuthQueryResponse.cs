using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenBrandAuthQueryResponse.
    /// </summary>
    public class AlipayOpenBrandAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("brand_auth_query_open_api_result")]
        public List<BrandAuthQueryOpenApiResult> Result { get; set; }
    }
}
