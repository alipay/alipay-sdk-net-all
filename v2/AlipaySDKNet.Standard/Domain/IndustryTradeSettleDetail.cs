using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryTradeSettleDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryTradeSettleDetail : AopObject
    {
        /// <summary>
        /// 实际操作金额，单位为元，两位小数。该参数的值为分账或补差或结算时传入
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        [XmlElement("operation_dt")]
        public string OperationDt { get; set; }

        /// <summary>
        /// 商户操作序列号。商户发起请求的外部请求号。
        /// </summary>
        [XmlElement("operation_serial_no")]
        public string OperationSerialNo { get; set; }

        /// <summary>
        /// 结算操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)、settle(结算)、settle_refund(退结算)、on_settle(待结算)。
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 商户请求的转入账号
        /// </summary>
        [XmlElement("ori_trans_in")]
        public string OriTransIn { get; set; }

        /// <summary>
        /// 商户请求的转出账号
        /// </summary>
        [XmlElement("ori_trans_out")]
        public string OriTransOut { get; set; }

        /// <summary>
        /// 转入账号
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转出账号
        /// </summary>
        [XmlElement("trans_out")]
        public string TransOut { get; set; }
    }
}
