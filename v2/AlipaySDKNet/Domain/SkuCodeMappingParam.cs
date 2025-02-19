using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCodeMappingParam Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCodeMappingParam : AopObject
    {
        /// <summary>
        /// 商家自定义当前的店内码/货号
        /// </summary>
        [XmlElement("source_sku_code")]
        public string SourceSkuCode { get; set; }

        /// <summary>
        /// 商家自定义需要修改成的新店内码/货号
        /// </summary>
        [XmlElement("target_sku_code")]
        public string TargetSkuCode { get; set; }
    }
}
