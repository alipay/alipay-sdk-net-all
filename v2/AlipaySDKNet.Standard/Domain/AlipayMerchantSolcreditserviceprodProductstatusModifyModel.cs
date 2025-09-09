using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodProductstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodProductstatusModifyModel : AopObject
    {
        /// <summary>
        /// 系统生成的商品编号
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 上架: PRODUCT_UP;下架: PRODUCT_DOWN
        /// </summary>
        [XmlElement("product_status")]
        public string ProductStatus { get; set; }
    }
}
