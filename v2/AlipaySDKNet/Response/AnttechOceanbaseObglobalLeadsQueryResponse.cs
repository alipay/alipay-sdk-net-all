using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadsQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalLeadsQueryResponse : AopResponse
    {
        /// <summary>
        /// 海图商机详情
        /// </summary>
        [XmlElement("result")]
        public LeadsDTO Result { get; set; }
    }
}
