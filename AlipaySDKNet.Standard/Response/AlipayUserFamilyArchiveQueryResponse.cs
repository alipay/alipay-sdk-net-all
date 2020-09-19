using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFamilyArchiveQueryResponse.
    /// </summary>
    public class AlipayUserFamilyArchiveQueryResponse : AopResponse
    {
        /// <summary>
        /// 家庭档案列表，包含档案id、档案详情等
        /// </summary>
        [XmlArray("archive_list")]
        [XmlArrayItem("family_archive_detail")]
        public List<FamilyArchiveDetail> ArchiveList { get; set; }
    }
}
