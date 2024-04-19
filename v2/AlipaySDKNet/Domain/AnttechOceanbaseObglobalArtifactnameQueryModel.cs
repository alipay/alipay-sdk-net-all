using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalArtifactnameQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalArtifactnameQueryModel : AopObject
    {
        /// <summary>
        /// 制品平台上打包制品归属的项目名
        /// </summary>
        [XmlElement("query_artifact_name_request")]
        public string QueryArtifactNameRequest { get; set; }
    }
}
