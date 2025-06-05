using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCodeItemStatusFailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCodeItemStatusFailDTO : AopObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商家商品sku编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
