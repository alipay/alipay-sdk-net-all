using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfleadsModifyResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfleadsModifyResponse : AopResponse
    {
        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
