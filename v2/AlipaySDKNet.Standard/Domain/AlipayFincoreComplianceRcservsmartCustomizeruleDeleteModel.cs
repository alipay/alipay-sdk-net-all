using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservsmartCustomizeruleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservsmartCustomizeruleDeleteModel : AopObject
    {
        /// <summary>
        /// 调用方系统信息
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 自定义规则信息
        /// </summary>
        [XmlElement("rcsmart_biz_request")]
        public CommercializationDeleteRuleReq RcsmartBizRequest { get; set; }
    }
}
