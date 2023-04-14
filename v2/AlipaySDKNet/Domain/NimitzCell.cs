using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzCell Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzCell : AopObject
    {
        /// <summary>
        /// Boolean 值
        /// </summary>
        [XmlElement("b_val")]
        public bool BVal { get; set; }

        /// <summary>
        /// Double 值
        /// </summary>
        [XmlElement("d_val")]
        public string DVal { get; set; }

        /// <summary>
        /// Int 值
        /// </summary>
        [XmlElement("i_64_val")]
        public string I64Val { get; set; }

        /// <summary>
        /// String 值
        /// </summary>
        [XmlElement("s_val")]
        public string SVal { get; set; }
    }
}
