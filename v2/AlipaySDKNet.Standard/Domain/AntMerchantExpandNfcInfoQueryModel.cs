using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandNfcInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandNfcInfoQueryModel : AopObject
    {
        /// <summary>
        /// NFC链接URL列表
        /// </summary>
        [XmlArray("nfc_url_list")]
        [XmlArrayItem("string")]
        public List<string> NfcUrlList { get; set; }
    }
}
