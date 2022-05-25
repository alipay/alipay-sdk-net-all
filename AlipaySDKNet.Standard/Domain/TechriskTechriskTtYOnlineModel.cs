using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskTechriskTtYOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskTechriskTtYOnlineModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("test_1")]
        public ManjiangTestab Test1 { get; set; }
    }
}
