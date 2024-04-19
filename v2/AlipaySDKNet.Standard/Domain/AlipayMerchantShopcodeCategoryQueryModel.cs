using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantShopcodeCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantShopcodeCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 请求流水号，调用者可自定义传入，平台仅作为请求调用记录
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
