using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesSolutionExt Data Structure.
    /// </summary>
    [Serializable]
    public class SalesSolutionExt : AopObject
    {
        /// <summary>
        /// 批量签约的数量（该字段只在先卖进后绑定模式下使用）
        /// </summary>
        [XmlElement("batch_sign_count")]
        public long BatchSignCount { get; set; }

        /// <summary>
        /// 必须是数字格式，单位元，在使用全额付动态价格方案做卖进时，根据该字段传入该次卖进的价格。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
