using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftSkuLabelQueryResponse.
    /// </summary>
    public class AnttechNftSkuLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 藏品标颜色
        /// </summary>
        [XmlElement("sku_label_color")]
        public string SkuLabelColor { get; set; }
    }
}
