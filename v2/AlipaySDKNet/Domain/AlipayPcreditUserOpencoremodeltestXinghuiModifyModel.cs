using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditUserOpencoremodeltestXinghuiModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditUserOpencoremodeltestXinghuiModifyModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }
    }
}
