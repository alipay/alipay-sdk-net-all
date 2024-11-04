using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrPoboManualOperationApplyRequestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrPoboManualOperationApplyRequestDTO : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public TuitionMoneyDTO RefundAmount { get; set; }

        /// <summary>
        /// 需求操作类型
        /// </summary>
        [XmlElement("required_operation_type")]
        public string RequiredOperationType { get; set; }
    }
}
