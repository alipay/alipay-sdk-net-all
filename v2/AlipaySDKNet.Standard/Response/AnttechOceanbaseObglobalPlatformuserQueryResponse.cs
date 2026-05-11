using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalPlatformuserQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalPlatformuserQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("platform_user_query_response")]
        public List<PlatformUserQueryResponse> Result { get; set; }
    }
}
