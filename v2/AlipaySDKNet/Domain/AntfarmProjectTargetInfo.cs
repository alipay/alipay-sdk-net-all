using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfarmProjectTargetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AntfarmProjectTargetInfo : AopObject
    {
        /// <summary>
        /// 标的物当前捐赠的数量
        /// </summary>
        [XmlElement("current_donation_count")]
        public long CurrentDonationCount { get; set; }

        /// <summary>
        /// 捐赠标的物 id
        /// </summary>
        [XmlElement("donation_target_id")]
        public string DonationTargetId { get; set; }

        /// <summary>
        /// 捐赠标的物名称
        /// </summary>
        [XmlElement("donation_target_name")]
        public string DonationTargetName { get; set; }

        /// <summary>
        /// 标的物额度
        /// </summary>
        [XmlElement("quota")]
        public long Quota { get; set; }
    }
}
