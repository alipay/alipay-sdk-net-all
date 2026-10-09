using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseSubaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseSubaccountQueryModel : AopObject
    {
        /// <summary>
        /// 财资子户查询入参模型
        /// </summary>
        [XmlElement("sub_account_query_request")]
        public SubAccountQueryRequest SubAccountQueryRequest { get; set; }
    }
}
