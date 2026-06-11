using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementAdditionalMediaInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementAdditionalMediaInfoVO : AopObject
    {
        /// <summary>
        /// 签收底单 URL (jpg)
        /// </summary>
        [XmlElement("electronic_signature_url")]
        public string ElectronicSignatureUrl { get; set; }

        /// <summary>
        /// 电子存根URL（jpg）
        /// </summary>
        [XmlElement("electronic_stub_url")]
        public string ElectronicStubUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("face_active_url_list")]
        [XmlArrayItem("string")]
        public List<string> FaceActiveUrlList { get; set; }

        /// <summary>
        /// 面单 URL（pdf）
        /// </summary>
        [XmlElement("face_document_url")]
        public string FaceDocumentUrl { get; set; }

        /// <summary>
        /// 签收回执单PDF地址
        /// </summary>
        [XmlElement("face_sign_url")]
        public string FaceSignUrl { get; set; }

        /// <summary>
        /// 路由轨迹 URL（pdf）
        /// </summary>
        [XmlElement("route_tracking_url")]
        public string RouteTrackingUrl { get; set; }
    }
}
