using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCustomerQueryResponse : AopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public CustomerNameResponse Result { get; set; }
    }
}
