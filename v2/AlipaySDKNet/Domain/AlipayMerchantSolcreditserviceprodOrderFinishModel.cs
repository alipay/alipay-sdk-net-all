using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodOrderFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodOrderFinishModel : AopObject
    {
        /// <summary>
        /// 扣款失败资金追回（继续扣款）： FUNDS_RECOVERY 立即完结无需追回资金： IMMEDIATELY_END
        /// </summary>
        [XmlElement("end_mode")]
        public string EndMode { get; set; }

        /// <summary>
        /// 系统生成订单唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
