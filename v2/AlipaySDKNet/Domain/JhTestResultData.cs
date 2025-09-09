using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JhTestResultData Data Structure.
    /// </summary>
    [Serializable]
    public class JhTestResultData : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("test_result")]
        public string TestResult { get; set; }
    }
}
