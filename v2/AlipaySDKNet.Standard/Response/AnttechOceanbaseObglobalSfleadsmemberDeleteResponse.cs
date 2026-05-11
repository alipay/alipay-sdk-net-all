using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsmemberDeleteResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfleadsmemberDeleteResponse : AopResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
