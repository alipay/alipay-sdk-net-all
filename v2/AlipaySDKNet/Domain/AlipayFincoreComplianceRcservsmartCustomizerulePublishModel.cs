using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservsmartCustomizerulePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservsmartCustomizerulePublishModel : AopObject
    {
        /// <summary>
        /// 调用方系统信息
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 自定义规则请求
        /// </summary>
        [XmlElement("rcsmart_biz_request")]
        public CommercializationCustomizeRuleReq RcsmartBizRequest { get; set; }
    }
}
