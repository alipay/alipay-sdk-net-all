using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceApplyModel : AopObject
    {
        /// <summary>
        /// 行业类目id,获取请参考<a href="https://opendocs.alipay.com/mini/03ci0w?pathHash=ed3c875c">各个行业场景服务接入资料</a>
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 外部业务编号,平台会基于appId+out_biz_no做幂等控制，如果出现幂等，会返回幂等的service_code
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务schema版本
        /// </summary>
        [XmlElement("schema_version")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务编码, 首次提报时设置空值，支付宝侧返回ServiceCode；当传入serviceCode，则对已提报服务做编辑操作。
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务xml,格式请参考<a href="https://opendocs.alipay.com/mini/03cj40?pathHash=a5de4bd9">Schema 规则介绍</a>
        /// </summary>
        [XmlElement("service_xml")]
        public string ServiceXml { get; set; }

        /// <summary>
        /// 默认值:DEFAULT。
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 商户提报服务履约类型
        /// </summary>
        [XmlElement("user_service_delivery_type")]
        public string UserServiceDeliveryType { get; set; }
    }
}
