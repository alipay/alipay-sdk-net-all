using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPlanCancelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentPlanCancelInfo : AopObject
    {
        /// <summary>
        /// 取消当前分期以及之后的所有分期
        /// </summary>
        [XmlElement("cancel_start_installment_no")]
        public long CancelStartInstallmentNo { get; set; }

        /// <summary>
        /// 取消原因编码
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 取消原因描述
        /// </summary>
        [XmlElement("reason_desc")]
        public string ReasonDesc { get; set; }
    }
}
