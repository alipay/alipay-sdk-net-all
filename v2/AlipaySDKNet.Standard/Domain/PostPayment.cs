using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PostPayment Data Structure.
    /// </summary>
    [Serializable]
    public class PostPayment : AopObject
    {
        /// <summary>
        /// 后付费金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 计费说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 后付费项目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
