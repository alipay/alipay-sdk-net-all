using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleExtraParams Data Structure.
    /// </summary>
    [Serializable]
    public class SettleExtraParams : AopObject
    {
        /// <summary>
        /// quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT
        /// </summary>
        [XmlElement("quit_type")]
        public string QuitType { get; set; }

        /// <summary>
        /// action_type选择PAY_TO_ZERO时必填， "SERVICE_CANCELED":"服务已取消", "OTHER_CHANNEL_PERFORMANCE":"户已通过其他方式履约"
        /// </summary>
        [XmlElement("settle_adjust_reason")]
        public string SettleAdjustReason { get; set; }
    }
}
