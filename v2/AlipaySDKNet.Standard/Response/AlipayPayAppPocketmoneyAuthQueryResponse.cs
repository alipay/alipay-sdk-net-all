using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthQueryResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// app信息
        /// </summary>
        [XmlArray("app_infos")]
        [XmlArrayItem("watch_app_info")]
        public List<WatchAppInfo> AppInfos { get; set; }

        /// <summary>
        /// 授权结果，枚举值（ok：授权成功，exist：已经存在）
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }

        /// <summary>
        /// 零花钱ID
        /// </summary>
        [XmlElement("change_code_id")]
        public string ChangeCodeId { get; set; }

        /// <summary>
        /// 厂商家长ID
        /// </summary>
        [XmlElement("vendor_parent_id")]
        public string VendorParentId { get; set; }
    }
}
