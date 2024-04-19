using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplicableVersionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApplicableVersionDTO : AopObject
    {
        /// <summary>
        /// 其他版本List
        /// </summary>
        [XmlArray("other_online_versions")]
        [XmlArrayItem("ob_artifac_online_version_query_response")]
        public List<ObArtifacOnlineVersionQueryResponse> OtherOnlineVersions { get; set; }

        /// <summary>
        /// 标准上线版本List
        /// </summary>
        [XmlArray("standard_online_versions")]
        [XmlArrayItem("ob_artifac_online_version_query_response")]
        public List<ObArtifacOnlineVersionQueryResponse> StandardOnlineVersions { get; set; }
    }
}
