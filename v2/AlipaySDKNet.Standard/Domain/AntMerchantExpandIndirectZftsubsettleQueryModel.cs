using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftsubsettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftsubsettleQueryModel : AopObject
    {
        /// <summary>
        /// 二级商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
