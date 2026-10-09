using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfBillproductableamtQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfBillproductableamtQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，固定，WF提前收款个人
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

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
