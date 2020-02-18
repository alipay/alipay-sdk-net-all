using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiStagePayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MultiStagePayInfo : AopObject
    {
        /// <summary>
        /// 按月均匀支付:PAY_MONTHLY
        /// </summary>
        [XmlElement("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 每期的支付信息的列表
        /// </summary>
        [XmlArray("stage_lines")]
        [XmlArrayItem("multi_stage_pay_line_info")]
        public List<MultiStagePayLineInfo> StageLines { get; set; }

        /// <summary>
        /// 总支付金额，单位为元，最多小数点后面2位
        /// </summary>
        [XmlElement("total_payment_amount")]
        public string TotalPaymentAmount { get; set; }
    }
}
