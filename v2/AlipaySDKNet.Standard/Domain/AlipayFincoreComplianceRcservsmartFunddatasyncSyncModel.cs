using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservsmartFunddatasyncSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservsmartFunddatasyncSyncModel : AopObject
    {
        /// <summary>
        /// 调用方系统信息
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 中欧基金数据同步请求
        /// </summary>
        [XmlElement("rcsmart_biz_request")]
        public CommercializationSyncDataReq RcsmartBizRequest { get; set; }
    }
}
