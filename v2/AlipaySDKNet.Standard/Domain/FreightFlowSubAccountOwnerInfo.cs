using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowSubAccountOwnerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowSubAccountOwnerInfo : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 归属人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
