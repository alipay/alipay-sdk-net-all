using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Lockaccountsync Data Structure.
    /// </summary>
    [Serializable]
    public class Lockaccountsync : AopObject
    {
        /// <summary>
        /// 亚马逊offerid
        /// </summary>
        [XmlElement("offerid")]
        public string Offerid { get; set; }

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
        /// 站点
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 用户站点id
        /// </summary>
        [XmlElement("siteuserid")]
        public string Siteuserid { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
