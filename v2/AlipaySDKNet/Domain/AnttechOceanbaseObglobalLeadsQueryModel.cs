using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalLeadsQueryModel : AopObject
    {
        /// <summary>
        /// 海图商机查询请求
        /// </summary>
        [XmlElement("describe_leads_request")]
        public GetLeadsByLeadsCodeRequest DescribeLeadsRequest { get; set; }
    }
}
