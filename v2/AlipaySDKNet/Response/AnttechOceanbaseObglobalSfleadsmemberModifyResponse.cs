using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsmemberModifyResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfleadsmemberModifyResponse : AopResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
