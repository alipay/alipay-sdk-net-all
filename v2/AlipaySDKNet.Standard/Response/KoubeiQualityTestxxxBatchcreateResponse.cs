using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiQualityTestxxxBatchcreateResponse.
    /// </summary>
    public class KoubeiQualityTestxxxBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oss_path")]
        public string OssPath { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("www")]
        public string Www { get; set; }
    }
}
