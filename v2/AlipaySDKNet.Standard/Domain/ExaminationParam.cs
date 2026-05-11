using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationParam Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationParam : AopObject
    {
        /// <summary>
        /// 外部商品ID集合与pdf链接关系
        /// </summary>
        [XmlArray("item_id_to_pdf")]
        [XmlArrayItem("fulfillment_item_pdf_info")]
        public List<FulfillmentItemPdfInfo> ItemIdToPdf { get; set; }
    }
}
