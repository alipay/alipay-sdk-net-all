using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuUpdateSuccessInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuUpdateSuccessInfoDTO : AopObject
    {
        /// <summary>
        /// 商家自定义当前sku的店内码/货号
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
