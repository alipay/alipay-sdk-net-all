using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoRebateBalanceQueryResponse.
    /// </summary>
    public class AlipayEcoRebateBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 给用户发放的集分宝数量
        /// </summary>
        [XmlElement("rebate_jfb")]
        public string RebateJfb { get; set; }

        /// <summary>
        /// 表示商品的返利比例，例如0.1表示返利比例为10%
        /// </summary>
        [XmlElement("rebate_rate")]
        public string RebateRate { get; set; }

        /// <summary>
        /// 表示当前用户是否已注册返利卡，如果已注册，则显示相应的返利信息，否则，显示开卡信息
        /// </summary>
        [XmlElement("registered")]
        public bool Registered { get; set; }

        /// <summary>
        /// 商家集分宝余额是否足够，如果足够，就显示相应的返利比例，如果不够，则不显示返利信息
        /// </summary>
        [XmlElement("sufficient_balance")]
        public bool SufficientBalance { get; set; }
    }
}
