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
        /// 2
        /// </summary>
        [XmlElement("s_openid")]
        public string SOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss_open_id")]
        public string SssOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ssss")]
        public string Ssss { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("test_1")]
        public ManjiangTestab Test1 { get; set; }
    }
}
