using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstFundFlowRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InstFundFlowRecordDTO : AopObject
    {
        /// <summary>
        /// 资金池ID
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("credit_account_no")]
        public string CreditAccountNo { get; set; }

        /// <summary>
        /// 收款账户类型
        /// </summary>
        [XmlElement("credit_account_type")]
        public string CreditAccountType { get; set; }

        /// <summary>
        /// 收款用户openid
        /// </summary>
        [XmlElement("credit_open_id")]
        public string CreditOpenId { get; set; }

        /// <summary>
        /// 收款用户ID
        /// </summary>
        [XmlElement("credit_user_id")]
        public string CreditUserId { get; set; }

        /// <summary>
        /// 付款账号
        /// </summary>
        [XmlElement("debit_account_no")]
        public string DebitAccountNo { get; set; }

        /// <summary>
        /// 付款账户类型
        /// </summary>
        [XmlElement("debit_account_type")]
        public string DebitAccountType { get; set; }

        /// <summary>
        /// 付款用户openid
        /// </summary>
        [XmlElement("debit_open_id")]
        public string DebitOpenId { get; set; }

        /// <summary>
        /// 付款用户ID
        /// </summary>
        [XmlElement("debit_user_id")]
        public string DebitUserId { get; set; }

        /// <summary>
        /// 执行时间，单位秒
        /// </summary>
        [XmlElement("gmt_execute_time")]
        public string GmtExecuteTime { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// SUCCESS：成功 INSUFFICIENT_BALANCE：余额不足 NO_INST_ABILITY_ITEM：无渠道可用 RETRY_OUT_OF_LIMITS：重试次数超限
        /// </summary>
        [XmlElement("pay_result_code")]
        public string PayResultCode { get; set; }

        /// <summary>
        /// 请求处理结果，无固定枚举值
        /// </summary>
        [XmlElement("pay_result_desc")]
        public string PayResultDesc { get; set; }

        /// <summary>
        /// INNER：主动调拨 OUTER：自动调拨
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// 执行结果状态，SUCCESS/FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易金额，单位分
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 消息通知唯一标识
        /// </summary>
        [XmlElement("unique_no")]
        public string UniqueNo { get; set; }
    }
}
