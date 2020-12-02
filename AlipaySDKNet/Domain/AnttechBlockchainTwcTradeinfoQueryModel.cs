using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcTradeinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainTwcTradeinfoQueryModel : AopObject
    {
        /// <summary>
        /// 支付者用户的支付宝id
        /// </summary>
        [XmlElement("buyeruid")]
        public string Buyeruid { get; set; }

        /// <summary>
        /// 卖家支付宝账户
        /// </summary>
        [XmlElement("selleruid")]
        public string Selleruid { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("tradefee")]
        public string Tradefee { get; set; }

        /// <summary>
        /// 支付订单id
        /// </summary>
        [XmlElement("tradeid")]
        public string Tradeid { get; set; }
    }
}
