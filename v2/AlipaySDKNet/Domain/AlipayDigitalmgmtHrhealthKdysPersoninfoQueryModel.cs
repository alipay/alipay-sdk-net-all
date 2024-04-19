using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthKdysPersoninfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrhealthKdysPersoninfoQueryModel : AopObject
    {
        /// <summary>
        /// 一般为带'-'的uuid
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 钉钉免登码
        /// </summary>
        [XmlElement("no_login_code")]
        public string NoLoginCode { get; set; }
    }
}
