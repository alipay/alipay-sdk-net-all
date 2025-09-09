using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodDeductionorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodDeductionorderQueryModel : AopObject
    {
        /// <summary>
        /// 系统生成扣款单唯一编号
        /// </summary>
        [XmlElement("deduction_order_no")]
        public string DeductionOrderNo { get; set; }

        /// <summary>
        /// 系统生成订单唯一编号，查询该订单下所有扣款单
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
