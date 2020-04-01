using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasRemitWithdrawNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitWithdrawNotifyModel : AopObject
    {
        /// <summary>
        /// APS定义的机构ID
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// json map 对象，透传一些额外的信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// ISO 4217规范的三位货币码
        /// </summary>
        [XmlElement("withdraw_amount_currency")]
        public string WithdrawAmountCurrency { get; set; }

        /// <summary>
        /// 对应货币的最小单位的货币值，例如 CNY，1就是1分
        /// </summary>
        [XmlElement("withdraw_amount_value")]
        public string WithdrawAmountValue { get; set; }

        /// <summary>
        /// 提现唯一id，由APS生成
        /// </summary>
        [XmlElement("withdraw_id")]
        public string WithdrawId { get; set; }

        /// <summary>
        /// 提现申请ID，由提现申请方定义
        /// </summary>
        [XmlElement("withdraw_request_id")]
        public string WithdrawRequestId { get; set; }

        /// <summary>
        /// 提现申请结果
        /// </summary>
        [XmlElement("withdraw_result_code")]
        public string WithdrawResultCode { get; set; }

        /// <summary>
        /// 提现结果消息
        /// </summary>
        [XmlElement("withdraw_result_message")]
        public string WithdrawResultMessage { get; set; }

        /// <summary>
        /// S 成功 F 失败
        /// </summary>
        [XmlElement("withdraw_result_status")]
        public string WithdrawResultStatus { get; set; }

        /// <summary>
        /// 提现结束时间
        /// </summary>
        [XmlElement("withdraw_time")]
        public string WithdrawTime { get; set; }
    }
}
