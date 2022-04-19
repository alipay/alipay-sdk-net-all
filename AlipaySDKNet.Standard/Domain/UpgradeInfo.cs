using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpgradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UpgradeInfo : AopObject
    {
        /// <summary>
        /// 升级后
        /// </summary>
        [XmlElement("upgrade_after")]
        public string UpgradeAfter { get; set; }

        /// <summary>
        /// 升级前
        /// </summary>
        [XmlElement("upgrade_before")]
        public string UpgradeBefore { get; set; }

        /// <summary>
        /// 是否强制升级
        /// </summary>
        [XmlElement("upgrade_force")]
        public bool UpgradeForce { get; set; }

        /// <summary>
        /// 升级目标
        /// </summary>
        [XmlElement("upgrade_target")]
        public string UpgradeTarget { get; set; }
    }
}
