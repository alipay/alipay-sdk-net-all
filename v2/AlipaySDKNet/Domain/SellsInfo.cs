using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellsInfo : AopObject
    {
        /// <summary>
        /// 商品客户自填销量
        /// </summary>
        [XmlElement("customer_sells")]
        public long CustomerSells { get; set; }

        /// <summary>
        /// 商品展示销量
        /// </summary>
        [XmlElement("display_sells")]
        public long DisplaySells { get; set; }

        /// <summary>
        /// 商品真实销量
        /// </summary>
        [XmlElement("real_sells")]
        public long RealSells { get; set; }

        /// <summary>
        /// 虚拟销量范围，模糊提供的销量信息，单位件。
        /// </summary>
        [XmlElement("virtual_sells_range")]
        public string VirtualSellsRange { get; set; }
    }
}
