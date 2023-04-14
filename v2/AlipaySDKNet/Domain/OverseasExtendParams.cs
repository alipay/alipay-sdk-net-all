using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OverseasExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class OverseasExtendParams : AopObject
    {
        /// <summary>
        /// 商品明细列表
        /// </summary>
        [XmlElement("goods_detail")]
        public string GoodsDetail { get; set; }
    }
}
