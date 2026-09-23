using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsTouchuvQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsTouchuvQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qr_code_url_list")]
        [XmlArrayItem("string")]
        public List<string> QrCodeUrlList { get; set; }
    }
}
