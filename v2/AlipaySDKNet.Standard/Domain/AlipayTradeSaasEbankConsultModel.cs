using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasEbankConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasEbankConsultModel : AopObject
    {
        /// <summary>
        /// 统一买家身份信息。已有Customer时传入buyer_id_type和buyer_id；未提供已有Customer时必须提供out_merchant_no。
        /// </summary>
        [XmlElement("buyer_info")]
        public SaasBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 咨询对应的订单金额，单位为元，必须大于0且最多保留两位小数。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
