using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodDeductionorderQueryResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodDeductionorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlArray("deduction_order_list")]
        [XmlArrayItem("deduction_order_d_t_o")]
        public List<DeductionOrderDTO> DeductionOrderList { get; set; }
    }
}
