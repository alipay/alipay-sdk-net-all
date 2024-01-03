using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasProductSkuListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductSkuListQueryModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
