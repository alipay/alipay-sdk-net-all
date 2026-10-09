using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfProductloanableamtQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfProductloanableamtQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，固定，WF提前收款个人
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 店铺id列表
        /// </summary>
        [XmlArray("sellerids")]
        [XmlArrayItem("string")]
        public List<string> Sellerids { get; set; }

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
