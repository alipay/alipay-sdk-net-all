using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Environmental Data Structure.
    /// </summary>
    [Serializable]
    public class Environmental : AopObject
    {
        /// <summary>
        /// 对应环保类型，可以发放的能量数
        /// </summary>
        [XmlElement("energy_amount")]
        public string EnergyAmount { get; set; }

        /// <summary>
        /// 商品对应的环保类型; 字典值: 临时商品: 替换装: FSC:
        /// </summary>
        [XmlElement("environmental")]
        public string Environmental_ { get; set; }
    }
}
