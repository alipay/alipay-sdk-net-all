using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiQualityTestxxxBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestxxxBatchcreateModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ss_openid")]
        public string SsOpenid { get; set; }
    }
}
