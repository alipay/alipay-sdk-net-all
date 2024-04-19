using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionListQueryResponse : AopResponse
    {
        /// <summary>
        /// 版本列表，根据版本号倒叙排列，即版本号大的在前面；如果不存在任何版本，返回空列表
        /// </summary>
        [XmlArray("app_version_infos")]
        [XmlArrayItem("app_version_info")]
        public List<AppVersionInfo> AppVersionInfos { get; set; }

        /// <summary>
        /// 小程序支付宝端每个状态的最新版本号列表(历史返回值，已不推荐使用，逐渐废弃)
        /// </summary>
        [XmlArray("app_versions")]
        [XmlArrayItem("string")]
        public List<string> AppVersions { get; set; }
    }
}
