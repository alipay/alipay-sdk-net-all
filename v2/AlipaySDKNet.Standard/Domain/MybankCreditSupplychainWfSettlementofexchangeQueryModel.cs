using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfSettlementofexchangeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfSettlementofexchangeQueryModel : AopObject
    {
        /// <summary>
        /// WF结汇金额
        /// </summary>
        [XmlElement("exchangeamount")]
        public AmountWf Exchangeamount { get; set; }

        /// <summary>
        /// 幂等请求id
        /// </summary>
        [XmlElement("requestid")]
        public string Requestid { get; set; }

        /// <summary>
        /// 固定，WF提前收款个人
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("sellerid")]
        public string Sellerid { get; set; }

        /// <summary>
        /// 站点
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
