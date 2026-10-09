using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsCollectionfaceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsCollectionfaceSyncModel : AopObject
    {
        /// <summary>
        /// IOT设备唯一标识
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// succeed or failed
        /// </summary>
        [XmlElement("collection_state")]
        public string CollectionState { get; set; }

        /// <summary>
        /// 人脸id
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// ISV请求ID
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }
    }
}
