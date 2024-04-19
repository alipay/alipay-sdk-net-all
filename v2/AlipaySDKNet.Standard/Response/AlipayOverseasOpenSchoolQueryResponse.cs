using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenSchoolQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenSchoolQueryResponse : AopResponse
    {
        /// <summary>
        /// 留学汇款对isv返回结果
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }

        /// <summary>
        /// 学校
        /// </summary>
        [XmlElement("school_list")]
        public TuitionISVSchoolDTO SchoolList { get; set; }
    }
}
