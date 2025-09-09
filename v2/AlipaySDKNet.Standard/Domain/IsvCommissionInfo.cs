using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvCommissionInfo : AopObject
    {
        /// <summary>
        /// 合作伙伴(一级角色)抽佣信息
        /// </summary>
        [XmlArray("commission_first_role_list")]
        [XmlArrayItem("commission_first_role_info")]
        public List<CommissionFirstRoleInfo> CommissionFirstRoleList { get; set; }

        /// <summary>
        /// 抽佣结束时间
        /// </summary>
        [XmlElement("commission_invalid_time")]
        public string CommissionInvalidTime { get; set; }

        /// <summary>
        /// 抽佣模式，统一模式或商品模式
        /// </summary>
        [XmlElement("commission_mode")]
        public string CommissionMode { get; set; }

        /// <summary>
        /// 抽佣场景
        /// </summary>
        [XmlElement("commission_scene")]
        public string CommissionScene { get; set; }

        /// <summary>
        /// 抽佣开始时间
        /// </summary>
        [XmlElement("commission_valid_time")]
        public string CommissionValidTime { get; set; }

        /// <summary>
        /// 服务商抽佣比例，统一模式时传。无单位，如0.0400表示4%
        /// </summary>
        [XmlElement("isv_rate")]
        public string IsvRate { get; set; }

        /// <summary>
        /// 商品抽佣比例。选择商品模式时，传每个商品的比例。
        /// </summary>
        [XmlArray("item_mode_commission_list")]
        [XmlArrayItem("item_mode_commission_info")]
        public List<ItemModeCommissionInfo> ItemModeCommissionList { get; set; }

        /// <summary>
        /// 是否是长期模式场景模式，为true时不用传抽佣时间
        /// </summary>
        [XmlElement("long_term")]
        public bool LongTerm { get; set; }

        /// <summary>
        /// 商家应用appId，代开发场景需要
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }
    }
}
