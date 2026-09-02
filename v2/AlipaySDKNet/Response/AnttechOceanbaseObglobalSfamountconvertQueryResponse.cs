using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfamountconvertQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfamountconvertQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SaleForceAmountConvertResponse Result { get; set; }
    }
}
