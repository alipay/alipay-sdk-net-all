using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupDeliveryDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupDeliveryDetailVO : AopObject
    {
        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 绑定场景
        /// </summary>
        [XmlElement("bind_scene")]
        public string BindScene { get; set; }

        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

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
        /// 群组id，表里唯一键，创建群组自动生成
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 定义群组分类，便于后台管理运营识别，可与设置的群名称保持一致；例：xx门店群，内部测试群
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 推广开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 推广状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
