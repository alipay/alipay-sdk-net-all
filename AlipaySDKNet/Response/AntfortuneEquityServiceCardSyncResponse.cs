using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneEquityServiceCardSyncResponse.
    /// </summary>
    public class AntfortuneEquityServiceCardSyncResponse : AopResponse
    {
        /// <summary>
        /// 是否同步成功
        /// </summary>
        [XmlElement("syn_result")]
        public bool SynResult { get; set; }
    }
}
