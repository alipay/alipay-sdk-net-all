using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsurlbindingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyMaterialsurlbindingQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qr_code_url_list")]
        [XmlArrayItem("string")]
        public List<string> QrCodeUrlList { get; set; }
    }
}
