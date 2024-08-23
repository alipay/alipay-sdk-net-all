using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateSubmitResonse Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateSubmitResonse : AopObject
    {
        /// <summary>
        /// 订购单编号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 订单编号/扣款单号
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 核销提交失败的原因
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 凭证次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// true:凭证提交成功 false:凭证提交失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
