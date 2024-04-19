using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeMobileappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeMobileappBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 移动应用信息列表
        /// </summary>
        [XmlArray("mobile_app_info_list")]
        [XmlArrayItem("mobile_app_info")]
        public List<MobileAppInfo> MobileAppInfoList { get; set; }
    }
}
