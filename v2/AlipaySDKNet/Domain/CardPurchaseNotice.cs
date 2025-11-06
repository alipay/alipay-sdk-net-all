using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPurchaseNotice Data Structure.
    /// </summary>
    [Serializable]
    public class CardPurchaseNotice : AopObject
    {
        /// <summary>
        /// 卡详情进行展示，可以设置适用人数。
        /// </summary>
        [XmlElement("max_users_options")]
        public string MaxUsersOptions { get; set; }

        /// <summary>
        /// 卡详情进行展示，可以设置适用人数。
        /// </summary>
        [XmlElement("max_users_value")]
        public long MaxUsersValue { get; set; }

        /// <summary>
        /// 卡详情进行展示，可以设置免预约或提前X个小时预约。
        /// </summary>
        [XmlElement("reserve_rules_options")]
        public string ReserveRulesOptions { get; set; }

        /// <summary>
        /// 卡详情进行展示，可以设置提前X个小时预约，支持传入0.5的整数倍。
        /// </summary>
        [XmlElement("reserve_rules_value")]
        public string ReserveRulesValue { get; set; }

        /// <summary>
        /// 卡详情进行展示，可以设置适用人群。
        /// </summary>
        [XmlElement("target_users_options")]
        public string TargetUsersOptions { get; set; }
    }
}
