using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcPreauthinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainTwcPreauthinfoQueryModel : AopObject
    {
        /// <summary>
        /// 预授权码
        /// </summary>
        [XmlElement("authno")]
        public string Authno { get; set; }

        /// <summary>
        /// 付款者支付宝账户
        /// </summary>
        [XmlElement("buyeruid")]
        public string Buyeruid { get; set; }

        /// <summary>
        /// 收款者支付宝账号uid
        /// </summary>
        [XmlElement("selleruid")]
        public string Selleruid { get; set; }

        /// <summary>
        /// 预授权金额
        /// </summary>
        [XmlElement("totalamount")]
        public string Totalamount { get; set; }
    }
}
