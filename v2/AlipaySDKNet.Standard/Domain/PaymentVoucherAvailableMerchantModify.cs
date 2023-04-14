using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherAvailableMerchantModify Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherAvailableMerchantModify : AopObject
    {
        /// <summary>
        /// 优惠券可以核销的直连商户PID。默认不修改。  限制：  1、核销商户范围只能增大不能减小。
        /// </summary>
        [XmlArray("available_pids")]
        [XmlArrayItem("string")]
        public List<string> AvailablePids { get; set; }

        /// <summary>
        /// 优惠券可以核销的间连商户SMID。默认不修改。  限制：  1、核销商户范围只能增大不能减小。
        /// </summary>
        [XmlArray("available_smids")]
        [XmlArrayItem("string")]
        public List<string> AvailableSmids { get; set; }
    }
}
