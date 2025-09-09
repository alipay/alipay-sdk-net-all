using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardAftersalesConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardAftersalesConfirmModel : AopObject
    {
        /// <summary>
        /// 售后单id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }

        /// <summary>
        /// 违约金金额，单位分，最大值取售后单上返回的违约金咨询结果，不收违约金传0
        /// </summary>
        [XmlElement("damages_cash")]
        public long DamagesCash { get; set; }

        /// <summary>
        /// 退款金额，单位分，直接取售后单上返回的退款金额
        /// </summary>
        [XmlElement("refund_cash")]
        public long RefundCash { get; set; }
    }
}
