using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantThirdactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantThirdactivityQueryModel : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 出资账户信息（2088）
        /// </summary>
        [XmlElement("invest_account")]
        public string InvestAccount { get; set; }

        /// <summary>
        /// 订单金额，单位元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }
    }
}
