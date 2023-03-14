using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservsmartCustomizeruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservsmartCustomizeruleModifyModel : AopObject
    {
        /// <summary>
        /// 调用方系统信息
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 规则状态内容
        /// </summary>
        [XmlElement("rcsmart_biz_request")]
        public CustomizeRuleResult RcsmartBizRequest { get; set; }
    }
}
