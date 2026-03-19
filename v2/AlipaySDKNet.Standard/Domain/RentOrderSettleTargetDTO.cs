using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderSettleTargetDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderSettleTargetDTO : AopObject
    {
        /// <summary>
        /// 结算目标
        /// </summary>
        [XmlElement("settle_target")]
        public string SettleTarget { get; set; }

        /// <summary>
        /// 结算对象openid
        /// </summary>
        [XmlElement("settle_target_openid")]
        public string SettleTargetOpenid { get; set; }

        /// <summary>
        /// 结算对象uid
        /// </summary>
        [XmlElement("settle_target_uid")]
        public string SettleTargetUid { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }
    }
}
