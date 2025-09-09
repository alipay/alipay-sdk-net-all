using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuUpdateFailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuUpdateFailInfoDTO : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商家自定义当前sku的店内码/货号
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
