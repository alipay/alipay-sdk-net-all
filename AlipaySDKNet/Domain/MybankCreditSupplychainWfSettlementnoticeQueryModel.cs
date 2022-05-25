using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfSettlementnoticeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfSettlementnoticeQueryModel : AopObject
    {
        /// <summary>
        /// 幂等请求id
        /// </summary>
        [XmlElement("requestid")]
        public string Requestid { get; set; }

        /// <summary>
        /// 场景码，固定，WF提前收款个人
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("sellerid")]
        public string Sellerid { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("settlementamount")]
        public AmountWf Settlementamount { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [XmlElement("siteuserid")]
        public string Siteuserid { get; set; }
    }
}
