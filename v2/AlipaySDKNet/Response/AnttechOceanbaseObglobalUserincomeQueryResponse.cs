using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalUserincomeQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalUserincomeQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("user_income_query_response")]
        public List<UserIncomeQueryResponse> Result { get; set; }
    }
}
