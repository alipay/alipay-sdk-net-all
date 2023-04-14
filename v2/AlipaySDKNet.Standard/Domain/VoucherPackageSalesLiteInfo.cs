using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageSalesLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageSalesLiteInfo : AopObject
    {
        /// <summary>
        /// 券包预算，单位是份数
        /// </summary>
        [XmlElement("budget")]
        public long Budget { get; set; }

        /// <summary>
        /// 券包售卖价格，单位是元
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }
    }
}
