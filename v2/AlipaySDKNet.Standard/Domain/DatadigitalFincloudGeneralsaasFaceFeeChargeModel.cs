using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceFeeChargeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceFeeChargeModel : AopObject
    {
        /// <summary>
        /// 云上人脸服务生成的单据号
        /// </summary>
        [XmlElement("certify_no")]
        public string CertifyNo { get; set; }

        /// <summary>
        /// 开放平台上入驻的商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 云上核身的产品码
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 该字段废弃不用。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 人脸服务中定义的场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 单据完成服务时间
        /// </summary>
        [XmlElement("service_time")]
        public string ServiceTime { get; set; }
    }
}
