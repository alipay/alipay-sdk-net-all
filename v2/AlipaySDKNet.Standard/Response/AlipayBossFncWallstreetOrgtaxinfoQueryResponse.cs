using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncWallstreetOrgtaxinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncWallstreetOrgtaxinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// ou税务信息
        /// </summary>
        [XmlElement("result_set")]
        public OrgTaxInfoOpenApiDto ResultSet { get; set; }
    }
}
