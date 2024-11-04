using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupDeliveryCreateModel : AopObject
    {
        /// <summary>
        /// 推广计划绑定场景。specified_org 群组入群，city_group_join 按城市入群，shop_group_join 按门店入群。
        /// </summary>
        [XmlElement("bind_scene")]
        public string BindScene { get; set; }

        /// <summary>
        /// 推广计划入群规则ID。
        /// </summary>
        [XmlElement("delivery_join_rule_id")]
        public string DeliveryJoinRuleId { get; set; }

        /// <summary>
        /// 推广计划名称
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 推广结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 收款账号列表
        /// </summary>
        [XmlArray("group_accounts")]
        [XmlArrayItem("group_account_v_o")]
        public List<GroupAccountVO> GroupAccounts { get; set; }

        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成。
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 推广开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
