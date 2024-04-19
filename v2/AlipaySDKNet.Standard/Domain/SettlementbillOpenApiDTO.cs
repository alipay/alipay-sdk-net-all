using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettlementbillOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SettlementbillOpenApiDTO : AopObject
    {
        /// <summary>
        /// 外部的业务单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 结算单金额
        /// </summary>
        [XmlElement("settle_amount")]
        public MultiCurrencyMoneyOpenApi SettleAmount { get; set; }

        /// <summary>
        /// 生成的结算单号
        /// </summary>
        [XmlElement("settlement_bill_no")]
        public string SettlementBillNo { get; set; }
    }
}
