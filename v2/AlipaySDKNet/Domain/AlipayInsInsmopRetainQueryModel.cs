using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsInsmopRetainQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsInsmopRetainQueryModel : AopObject
    {
        /// <summary>
        /// 机构接入云呼的口令
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 保险机构ID
        /// </summary>
        [XmlElement("ins_code")]
        public string InsCode { get; set; }
    }
}
