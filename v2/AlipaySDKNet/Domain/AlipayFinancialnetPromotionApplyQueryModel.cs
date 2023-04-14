using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetPromotionApplyQueryModel : AopObject
    {
        /// <summary>
        /// 进件订单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请人支付宝UID
        /// </summary>
        [XmlElement("apply_open_id")]
        public string ApplyOpenId { get; set; }

        /// <summary>
        /// 申请人支付宝UID
        /// </summary>
        [XmlElement("apply_user_id")]
        public string ApplyUserId { get; set; }
    }
}
