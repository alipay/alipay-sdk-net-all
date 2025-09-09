using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinSymbolDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FinSymbolDetail : AopObject
    {
        /// <summary>
        /// 标的编码
        /// </summary>
        [XmlElement("symbol_code")]
        public string SymbolCode { get; set; }

        /// <summary>
        /// 标的名称
        /// </summary>
        [XmlElement("symbol_name")]
        public string SymbolName { get; set; }
    }
}
