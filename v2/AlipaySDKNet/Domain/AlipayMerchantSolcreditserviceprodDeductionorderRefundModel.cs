using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodDeductionorderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodDeductionorderRefundModel : AopObject
    {
        /// <summary>
        /// 退款金额(单位元)，最多2位小数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 系统生成扣款单唯一编号
        /// </summary>
        [XmlElement("deduction_order_no")]
        public string DeductionOrderNo { get; set; }

        /// <summary>
        /// 商户保证唯一
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
