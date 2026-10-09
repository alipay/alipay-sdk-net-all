using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditGoodsConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditGoodsConfirmModel : AopObject
    {
        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }
    }
}
