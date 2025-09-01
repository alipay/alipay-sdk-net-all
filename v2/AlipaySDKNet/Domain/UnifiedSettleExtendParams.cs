using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnifiedSettleExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class UnifiedSettleExtendParams : AopObject
    {
        /// <summary>
        /// 提现到银行卡备注
        /// </summary>
        [XmlElement("bank_memo")]
        public string BankMemo { get; set; }

        /// <summary>
        /// 表示机构打款单号，一个 inst_serial_no 对应用户的一次打款。回传来账明细查询接口返回的 order_id 字段即可。
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 备注 当前字段已废弃(不需要该参数了不需要该参数了)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 原始订单金额，单位元
        /// </summary>
        [XmlElement("original_order_amount")]
        public string OriginalOrderAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 直付通结算模式，账期，请款，自动，详情参考直付通接入文档
        /// </summary>
        [XmlElement("settle_mode")]
        public string SettleMode { get; set; }

        /// <summary>
        /// 用于指定收结易订单的附言，可用于对账
        /// </summary>
        [XmlElement("trans_memo")]
        public string TransMemo { get; set; }
    }
}
