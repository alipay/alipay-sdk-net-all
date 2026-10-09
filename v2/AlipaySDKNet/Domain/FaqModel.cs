using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FaqModel Data Structure.
    /// </summary>
    [Serializable]
    public class FaqModel : AopObject
    {
        /// <summary>
        /// 回答
        /// </summary>
        [XmlElement("column_a")]
        public string ColumnA { get; set; }

        /// <summary>
        /// 问题
        /// </summary>
        [XmlElement("column_q")]
        public string ColumnQ { get; set; }
    }
}
