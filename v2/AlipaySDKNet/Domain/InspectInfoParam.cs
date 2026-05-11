using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InspectInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class InspectInfoParam : AopObject
    {
        /// <summary>
        /// 耗材费用，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("consumables_price")]
        public string ConsumablesPrice { get; set; }

        /// <summary>
        /// 额外药品费用，单位元。币种 ：人民币。
        /// </summary>
        [XmlElement("drug_price")]
        public string DrugPrice { get; set; }
    }
}
