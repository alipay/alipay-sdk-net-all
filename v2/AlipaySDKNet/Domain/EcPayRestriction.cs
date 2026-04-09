using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcPayRestriction Data Structure.
    /// </summary>
    [Serializable]
    public class EcPayRestriction : AopObject
    {
        /// <summary>
        /// 账户使用条件类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 账户使用范围限定。是企业码平台定义的费用类型，如差旅（ENT_TRAVEL）、外卖（TAKE_AWAY），更多类型请咨询业务
        /// </summary>
        [XmlArray("ranges")]
        [XmlArrayItem("string")]
        public List<string> Ranges { get; set; }
    }
}
