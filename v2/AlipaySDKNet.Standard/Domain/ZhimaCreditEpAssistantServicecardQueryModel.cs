using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantServicecardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantServicecardQueryModel : AopObject
    {
        /// <summary>
        /// 渠道侧商户唯一ID，1688为aliId
        /// </summary>
        [XmlElement("ali_id")]
        public string AliId { get; set; }
    }
}
