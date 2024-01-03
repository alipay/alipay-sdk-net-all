using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockMiniappMetaCreateResponse.
    /// </summary>
    public class AntfortuneStockMiniappMetaCreateResponse : AopResponse
    {
        /// <summary>
        /// traceid
        /// </summary>
        [XmlElement("trace")]
        public string Trace { get; set; }
    }
}
