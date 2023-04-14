using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardExtraInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardExtraInfoDTO : AopObject
    {
        /// <summary>
        /// 用户操作类型，枚举如下： OPEN 开通 UPGRADE 升级 DOWNGRADE 降级 RENEW 续费
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 用户连续购买付费卡信息
        /// </summary>
        [XmlElement("cycle_info")]
        public PaidOuterCardCycleInfoDTO CycleInfo { get; set; }

        /// <summary>
        /// 用户购买付费外卡基本信息
        /// </summary>
        [XmlElement("purchase_info")]
        public PaidOuterCardPurchaseInfoDTO PurchaseInfo { get; set; }
    }
}
