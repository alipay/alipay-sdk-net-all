using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherAvailableMerchant Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherAvailableMerchant : AopObject
    {
        /// <summary>
        /// 优惠券可核销的直连商户PID  限制： 1、available_pids和available_smids至少二选一。
        /// </summary>
        [XmlArray("available_pids")]
        [XmlArrayItem("string")]
        public List<string> AvailablePids { get; set; }

        /// <summary>
        /// 优惠券可核销的间连商户SMID  限制：  1、available_pids和available_smids至少二选一。
        /// </summary>
        [XmlArray("available_smids")]
        [XmlArrayItem("string")]
        public List<string> AvailableSmids { get; set; }
    }
}
