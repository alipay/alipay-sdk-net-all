using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSettleSettlementbillCancelModel : AopObject
    {
        /// <summary>
        /// 取消金额  该金额等于结算单的金额 用于校验   不支持部分取消
        /// </summary>
        [XmlElement("cancel_amount")]
        public MultiCurrencyMoneyOpenApi CancelAmount { get; set; }

        /// <summary>
        /// 外部业务单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 对应单据创建的来源 （系统名）
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
