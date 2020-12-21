using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FailExternalSync Data Structure.
    /// </summary>
    [Serializable]
    public class FailExternalSync : AopObject
    {
        /// <summary>
        /// 支付宝账单ID
        /// </summary>
        [XmlElement("alipay_bill_id")]
        public string AlipayBillId { get; set; }

        /// <summary>
        /// BILL_IS_PAY 已支付（ISV其他流程发起退款） BILL_IS_WAITINT_PAY 待支付中（ISV不做处理，等待超时或用户支付后重试） SYSTEM_ERROR 系统异常，可重试
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 外部账单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
