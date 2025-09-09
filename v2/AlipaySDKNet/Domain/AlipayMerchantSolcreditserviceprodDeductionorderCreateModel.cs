using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodDeductionorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodDeductionorderCreateModel : AopObject
    {
        /// <summary>
        /// 扣押金必填，不能大于押金剩余金额
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣押金必填
        /// </summary>
        [XmlElement("deduction_reason")]
        public string DeductionReason { get; set; }

        /// <summary>
        /// 押金扣款单: DEPOSIT 租金扣款单: RENT
        /// </summary>
        [XmlElement("deduction_type")]
        public string DeductionType { get; set; }

        /// <summary>
        /// 系统生成订单唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户保证唯一
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
