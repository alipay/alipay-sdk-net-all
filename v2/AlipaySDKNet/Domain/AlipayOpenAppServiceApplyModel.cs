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
        /// 行业类目id
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
        /// 服务xml
        /// </summary>
        [XmlElement("service_xml")]
        public string ServiceXml { get; set; }
    }
}
