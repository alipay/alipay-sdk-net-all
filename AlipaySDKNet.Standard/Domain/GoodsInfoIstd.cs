using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInfoIstd Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInfoIstd : AopObject
    {
        /// <summary>
        /// 交货信息，用于骑手交付商品
        /// </summary>
        [XmlElement("delivery_info")]
        public string DeliveryInfo { get; set; }

        /// <summary>
        /// 一级品类类目
        /// </summary>
        [XmlElement("first_class")]
        public string FirstClass { get; set; }

        /// <summary>
        /// 商品高度，单位为cm，精确到小数点后面两位
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 商品长度，单位为cm，精确到小数点后面两位
        /// </summary>
        [XmlElement("length")]
        public long Length { get; set; }

        /// <summary>
        /// 取货信息，用于骑手到店取货
        /// </summary>
        [XmlElement("pickup_info")]
        public string PickupInfo { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 二级品类类目
        /// </summary>
        [XmlElement("second_class")]
        public string SecondClass { get; set; }

        /// <summary>
        /// 货物重量，单位为kg，精确到小数点后两位
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }

        /// <summary>
        /// 商品宽度，单位为cm，精确到小数点后面两位
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
