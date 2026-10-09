using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpaydirectChargeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpaydirectChargeQueryModel : AopObject
    {
        /// <summary>
        /// 外部商品id，从管理小程序商品详情页获取
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }
    }
}
