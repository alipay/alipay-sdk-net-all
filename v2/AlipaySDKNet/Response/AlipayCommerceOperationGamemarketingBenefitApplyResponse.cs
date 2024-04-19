using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationGamemarketingBenefitApplyResponse.
    /// </summary>
    public class AlipayCommerceOperationGamemarketingBenefitApplyResponse : AopResponse
    {
        /// <summary>
        /// 返回值是个卡券兑换码的列表
        /// </summary>
        [XmlArray("apply_voucher_code_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyVoucherCodeList { get; set; }
    }
}
