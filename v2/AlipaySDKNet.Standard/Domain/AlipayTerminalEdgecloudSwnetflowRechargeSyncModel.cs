using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudSwnetflowRechargeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudSwnetflowRechargeSyncModel : AopObject
    {
        /// <summary>
        /// 同步流量卡充值单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁进行流量卡充值时传入的业务单号
        /// </summary>
        [XmlElement("trace_no")]
        public string TraceNo { get; set; }
    }
}
