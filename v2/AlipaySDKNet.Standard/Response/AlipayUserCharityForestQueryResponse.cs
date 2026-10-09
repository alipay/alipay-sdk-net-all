using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCharityForestQueryResponse.
    /// </summary>
    public class AlipayUserCharityForestQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否开通了蚂蚁森林
        /// </summary>
        [XmlElement("forest_user")]
        public bool ForestUser { get; set; }
    }
}
