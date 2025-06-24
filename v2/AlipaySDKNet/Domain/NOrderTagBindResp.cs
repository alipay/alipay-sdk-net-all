using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NOrderTagBindResp Data Structure.
    /// </summary>
    [Serializable]
    public class NOrderTagBindResp : AopObject
    {
        /// <summary>
        /// 需要绑定点位的碰一下链接
        /// </summary>
        [XmlArray("nfc_url")]
        [XmlArrayItem("string")]
        public List<string> NfcUrl { get; set; }
    }
}
