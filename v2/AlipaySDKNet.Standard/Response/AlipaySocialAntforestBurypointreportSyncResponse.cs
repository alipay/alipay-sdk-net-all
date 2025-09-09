using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestBurypointreportSyncResponse.
    /// </summary>
    public class AlipaySocialAntforestBurypointreportSyncResponse : AopResponse
    {
        /// <summary>
        /// 是否有访问
        /// </summary>
        [XmlElement("acknowledged")]
        public bool Acknowledged { get; set; }
    }
}
