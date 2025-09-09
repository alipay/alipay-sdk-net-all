using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdateCodeByCodeSuccessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCodeByCodeSuccessInfo : AopObject
    {
        /// <summary>
        /// 原itemcode
        /// </summary>
        [XmlElement("source_item_code")]
        public string SourceItemCode { get; set; }
    }
}
