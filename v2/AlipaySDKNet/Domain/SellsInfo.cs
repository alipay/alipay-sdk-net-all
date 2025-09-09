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
    }
}
