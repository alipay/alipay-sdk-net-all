using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountingLogVO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountingLogVO : AopObject
    {
        /// <summary>
        /// 交易账户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型:监管户-SUPERVISED_ACC,托管子户-ENTRUST_SUB_ACC
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 记账动作 IN:流入 OUT:流出
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 余额,人民币,单位元,1.23代表1.23元。注:因账务异步记账模式,此处余额展示可能会有延迟,不保证实时更新。
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 流水主键
        /// </summary>
        [XmlElement("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 对手方账户
        /// </summary>
        [XmlElement("other_account")]
        public string OtherAccount { get; set; }

        /// <summary>
        /// 外部请求号,跟分账或提现的out_request_no保持一致
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 交易金额,人民币,单位元,1.23代表1.23元
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("trans_memo")]
        public string TransMemo { get; set; }
    }
}
