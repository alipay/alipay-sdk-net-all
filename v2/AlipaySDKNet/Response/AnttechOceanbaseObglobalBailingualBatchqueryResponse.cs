using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalBailingualBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalBailingualBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [XmlElement("result")]
        public FindTextResponse Result { get; set; }
    }
}
