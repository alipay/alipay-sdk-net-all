using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataIotdataIdpsolutionProductinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataIdpsolutionProductinfoQueryModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }
    }
}
