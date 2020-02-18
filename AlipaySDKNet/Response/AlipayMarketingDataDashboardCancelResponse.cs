using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardCancelResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消授权失败仪表盘列表
        /// </summary>
        [XmlArray("dashboard_fail_list")]
        [XmlArrayItem("string")]
        public List<string> DashboardFailList { get; set; }

        /// <summary>
        /// 取消仪表盘授权结果
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
