using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfSinglepaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfSinglepaymentQueryModel : AopObject
    {
        /// <summary>
        /// 网商支用编号
        /// </summary>
        [XmlElement("billno")]
        public string Billno { get; set; }

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
