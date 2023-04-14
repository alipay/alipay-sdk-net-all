using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniBenefitMultibundleConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBenefitMultibundleConsultModel : AopObject
    {
        /// <summary>
        /// 业务场景，由支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 权益类目，类目列表请参见文档
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("login_mobile_id")]
        public string LoginMobileId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
