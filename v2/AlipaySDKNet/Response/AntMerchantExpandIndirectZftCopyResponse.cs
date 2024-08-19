using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftCopyResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftCopyResponse : AopResponse
    {
        /// <summary>
        /// 迁移后的直付通二级商户smid
        /// </summary>
        [XmlElement("smid_new")]
        public string SmidNew { get; set; }
    }
}
