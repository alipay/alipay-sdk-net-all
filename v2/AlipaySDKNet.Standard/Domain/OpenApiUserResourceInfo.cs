using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiUserResourceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiUserResourceInfo : AopObject
    {
        /// <summary>
        /// 客服小二的2088id
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// buservice星云id
        /// </summary>
        [XmlElement("busvc_cloud_id")]
        public string BusvcCloudId { get; set; }

        /// <summary>
        /// antbuservice域账号
        /// </summary>
        [XmlElement("busvc_domain")]
        public string BusvcDomain { get; set; }

        /// <summary>
        /// antbuserviceId
        /// </summary>
        [XmlElement("busvc_id")]
        public string BusvcId { get; set; }

        /// <summary>
        /// antbuservice工号
        /// </summary>
        [XmlElement("busvc_no")]
        public string BusvcNo { get; set; }

        /// <summary>
        /// 旧平台用户id
        /// </summary>
        [XmlElement("clv_user_id")]
        public long ClvUserId { get; set; }

        /// <summary>
        /// 用户资源id
        /// </summary>
        [XmlElement("ur_id")]
        public string UrId { get; set; }
    }
}
