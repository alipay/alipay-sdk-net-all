using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleControl Data Structure.
    /// </summary>
    [Serializable]
    public class SaleControl : AopObject
    {
        /// <summary>
        /// 如果是多航段打包规则，传入一个：-1，否则的话，根据数字来判断是第几个航段
        /// </summary>
        [XmlElement("airline_no")]
        public string AirlineNo { get; set; }

        /// <summary>
        /// 机票售卖的策略描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 售卖限制的详情
        /// </summary>
        [XmlElement("detail")]
        public SaleControlDetail Detail { get; set; }

        /// <summary>
        /// 售卖限制的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
