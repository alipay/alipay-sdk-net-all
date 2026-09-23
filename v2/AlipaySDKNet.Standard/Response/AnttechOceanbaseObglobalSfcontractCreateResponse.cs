using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcontractCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfcontractCreateResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SalesForceCreateContractDTO Result { get; set; }
    }
}
