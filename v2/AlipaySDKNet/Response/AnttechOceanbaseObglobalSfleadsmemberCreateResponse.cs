using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsmemberCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfleadsmemberCreateResponse : AopResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public SaleForceLeadsMemberCreateDTO Result { get; set; }
    }
}
