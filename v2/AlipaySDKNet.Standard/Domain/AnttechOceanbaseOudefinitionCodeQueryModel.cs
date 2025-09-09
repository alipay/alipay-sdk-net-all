using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseOudefinitionCodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseOudefinitionCodeQueryModel : AopObject
    {
        /// <summary>
        /// ouCode查询请求体
        /// </summary>
        [XmlElement("ou_code_query_request")]
        public OuCodeQueryRequest OuCodeQueryRequest { get; set; }
    }
}
