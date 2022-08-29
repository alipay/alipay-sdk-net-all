using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservcenterRcsmartQueryModel : AopObject
    {
        /// <summary>
        /// 解语花鉴权对象
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 请求参数，保证业务请求幂等性，同时在请求完毕后，获取业务风险详情信息结果使用
        /// </summary>
        [XmlElement("approval_query")]
        public ApprovalQuery ApprovalQuery { get; set; }
    }
}
