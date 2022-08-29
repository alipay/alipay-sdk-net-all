using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizfundSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizfundSettleInfo : AopObject
    {
        /// <summary>
        /// 请款|账期 模式
        /// </summary>
        [XmlElement("settle_mode")]
        public string SettleMode { get; set; }

        /// <summary>
        /// 结算的目标对象类型
        /// </summary>
        [XmlElement("settle_target_type")]
        public string SettleTargetType { get; set; }
    }
}
