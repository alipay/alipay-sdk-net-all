using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderRequest : AopObject
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [XmlElement("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务的类型默认使用小程序 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
