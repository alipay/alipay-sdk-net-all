using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AACProspectFlashSaleResult Data Structure.
    /// </summary>
    [Serializable]
    public class AACProspectFlashSaleResult : AopObject
    {
        /// <summary>
        /// 发奖金额，单位：分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }
    }
}
