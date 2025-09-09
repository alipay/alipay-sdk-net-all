using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FirstSloved Data Structure.
    /// </summary>
    [Serializable]
    public class FirstSloved : AopObject
    {
        /// <summary>
        /// 客服2088id
        /// </summary>
        [XmlElement("agent_alipay_uid")]
        public string AgentAlipayUid { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        [XmlElement("agent_nickname")]
        public string AgentNickname { get; set; }

        /// <summary>
        /// 均响时长(秒)
        /// </summary>
        [XmlElement("avg_response_length")]
        public string AvgResponseLength { get; set; }

        /// <summary>
        /// 回流时间
        /// </summary>
        [XmlElement("backflow_time")]
        public string BackflowTime { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// 二级业务线
        /// </summary>
        [XmlElement("business_name_level_2")]
        public string BusinessNameLevel2 { get; set; }

        /// <summary>
        /// 进线渠道
        /// </summary>
        [XmlElement("call_in_user_type")]
        public string CallInUserType { get; set; }

        /// <summary>
        /// 一级类目
        /// </summary>
        [XmlElement("cat_name_level_1")]
        public string CatNameLevel1 { get; set; }

        /// <summary>
        /// 二级类目
        /// </summary>
        [XmlElement("cat_name_level_2")]
        public string CatNameLevel2 { get; set; }

        /// <summary>
        /// 三级类目
        /// </summary>
        [XmlElement("cat_name_level_3")]
        public string CatNameLevel3 { get; set; }

        /// <summary>
        /// 首响时长（秒）
        /// </summary>
        [XmlElement("first_response_length")]
        public string FirstResponseLength { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 是否中途断线
        /// </summary>
        [XmlElement("is_discontinue")]
        public string IsDiscontinue { get; set; }

        /// <summary>
        /// 是否首解
        /// </summary>
        [XmlElement("is_first_solved")]
        public string IsFirstSolved { get; set; }

        /// <summary>
        /// 在线渠道客户进人工是否有说话(热线默认有)
        /// </summary>
        [XmlElement("is_online_user_speak")]
        public string IsOnlineUserSpeak { get; set; }

        /// <summary>
        /// 是否派单
        /// </summary>
        [XmlElement("is_send")]
        public string IsSend { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("service_channel")]
        public string ServiceChannel { get; set; }

        /// <summary>
        /// 话务升级时间(秒)
        /// </summary>
        [XmlElement("session_upgrade_time")]
        public string SessionUpgradeTime { get; set; }

        /// <summary>
        /// 话务升级类型
        /// </summary>
        [XmlElement("session_upgrade_type")]
        public string SessionUpgradeType { get; set; }

        /// <summary>
        /// 转出业务线
        /// </summary>
        [XmlElement("transfer_business_name")]
        public string TransferBusinessName { get; set; }

        /// <summary>
        /// 转接或回流二级类目
        /// </summary>
        [XmlElement("transfer_cat_nam_level_2")]
        public string TransferCatNamLevel2 { get; set; }

        /// <summary>
        /// 转接或回流三级类目
        /// </summary>
        [XmlElement("transfer_cat_nam_level_3")]
        public string TransferCatNamLevel3 { get; set; }

        /// <summary>
        /// 转接或回流渠道
        /// </summary>
        [XmlElement("transfer_servive_channel")]
        public string TransferServiveChannel { get; set; }

        /// <summary>
        /// 转接或回流会话id
        /// </summary>
        [XmlElement("transfer_session_id")]
        public string TransferSessionId { get; set; }

        /// <summary>
        /// 转接或回流客服记录订单号
        /// </summary>
        [XmlElement("transfer_user_order_id")]
        public string TransferUserOrderId { get; set; }

        /// <summary>
        /// 未首解原因
        /// </summary>
        [XmlElement("unresolved_reason")]
        public string UnresolvedReason { get; set; }

        /// <summary>
        /// 升级后创建的工单号
        /// </summary>
        [XmlElement("upgrade_ticket_id")]
        public string UpgradeTicketId { get; set; }

        /// <summary>
        /// 客户guid
        /// </summary>
        [XmlElement("user_guid")]
        public string UserGuid { get; set; }

        /// <summary>
        /// 客服记录订单号
        /// </summary>
        [XmlElement("user_order_id")]
        public string UserOrderId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
