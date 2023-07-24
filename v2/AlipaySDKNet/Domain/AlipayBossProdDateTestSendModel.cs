using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdDateTestSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdDateTestSendModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }
    }
}
