using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCodeUpdateSuccessInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCodeUpdateSuccessInfoDTO : AopObject
    {
        /// <summary>
        /// 商家自定义当前sku的店内码/货号
        /// </summary>
        [XmlElement("source_sku_code")]
        public string SourceSkuCode { get; set; }
    }
}
