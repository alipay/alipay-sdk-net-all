using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcloudfeereductionQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfcloudfeereductionQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SaleForceQueryCouponResponseDTO Result { get; set; }
    }
}
