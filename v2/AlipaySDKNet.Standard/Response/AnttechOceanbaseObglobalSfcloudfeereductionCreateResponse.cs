using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcloudfeereductionCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfcloudfeereductionCreateResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SaleForceCouponCreateResponseDTO Result { get; set; }
    }
}
