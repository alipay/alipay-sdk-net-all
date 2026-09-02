using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeepFakeResult Data Structure.
    /// </summary>
    [Serializable]
    public class DeepFakeResult : AopObject
    {
        /// <summary>
        /// 检测明细
        /// </summary>
        [XmlElement("fake_reason")]
        public string FakeReason { get; set; }

        /// <summary>
        /// 检测是通过
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 检测分，取值0-1。
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
