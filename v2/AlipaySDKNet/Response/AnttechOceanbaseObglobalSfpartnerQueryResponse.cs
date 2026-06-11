using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfpartnerQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfpartnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SalesForcePartnerQueryResponseDTO Result { get; set; }
    }
}
