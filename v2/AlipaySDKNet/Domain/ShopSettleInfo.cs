using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopSettleInfo : AopObject
    {
        /// <summary>
        /// 结算到户的账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
