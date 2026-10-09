using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveLiveroomDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveLiveroomDataQueryModel : AopObject
    {
        /// <summary>
        /// 加密后的直播间id
        /// </summary>
        [XmlElement("encrypted_live_id")]
        public string EncryptedLiveId { get; set; }
    }
}
