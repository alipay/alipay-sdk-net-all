using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCodeItemStatusSuccessDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCodeItemStatusSuccessDTO : AopObject
    {
        /// <summary>
        /// 商家商品sku编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
