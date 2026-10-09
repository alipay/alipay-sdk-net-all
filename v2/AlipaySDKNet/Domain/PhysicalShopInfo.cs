using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhysicalShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PhysicalShopInfo : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("out_shop_num")]
        public string OutShopNum { get; set; }

        /// <summary>
        /// 物理门店id
        /// </summary>
        [XmlElement("physical_shop_id")]
        public string PhysicalShopId { get; set; }

        /// <summary>
        /// 物理门店名称
        /// </summary>
        [XmlElement("physical_shop_name")]
        public string PhysicalShopName { get; set; }
    }
}
