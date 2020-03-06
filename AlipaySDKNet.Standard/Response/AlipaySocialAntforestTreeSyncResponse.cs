using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestTreeSyncResponse.
    /// </summary>
    public class AlipaySocialAntforestTreeSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步是否成功
        /// </summary>
        [XmlElement("synced")]
        public bool Synced { get; set; }
    }
}
