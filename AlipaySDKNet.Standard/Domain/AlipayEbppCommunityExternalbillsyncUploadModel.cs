using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityExternalbillsyncUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityExternalbillsyncUploadModel : AopObject
    {
        /// <summary>
        /// 小区短名，本接口只支持按小区纬度动账
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 同步对象，最大长度100
        /// </summary>
        [XmlArray("external_sync_list")]
        [XmlArrayItem("external_sync_request")]
        public List<ExternalSyncRequest> ExternalSyncList { get; set; }
    }
}
