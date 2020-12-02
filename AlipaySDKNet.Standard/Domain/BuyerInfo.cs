using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BuyerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerInfo : AopObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
