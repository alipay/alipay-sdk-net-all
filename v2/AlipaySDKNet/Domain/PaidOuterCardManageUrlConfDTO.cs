using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardManageUrlConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardManageUrlConfDTO : AopObject
    {
        /// <summary>
        /// 连续购买管理地址。包括查看当前用户连续购买详情，关闭连续购买等功能
        /// </summary>
        [XmlElement("cycle_manage_url")]
        public string CycleManageUrl { get; set; }

        /// <summary>
        /// 付费外卡降级地址
        /// </summary>
        [XmlElement("downgrade_url")]
        public string DowngradeUrl { get; set; }

        /// <summary>
        /// 续费外卡退款地址
        /// </summary>
        [XmlElement("refund_url")]
        public string RefundUrl { get; set; }

        /// <summary>
        /// 付费外卡续费地址
        /// </summary>
        [XmlElement("renew_url")]
        public string RenewUrl { get; set; }

        /// <summary>
        /// 付费外卡升级地址
        /// </summary>
        [XmlElement("upgrade_url")]
        public string UpgradeUrl { get; set; }
    }
}
