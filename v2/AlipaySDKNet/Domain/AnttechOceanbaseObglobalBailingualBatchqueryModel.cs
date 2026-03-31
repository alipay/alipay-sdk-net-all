using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalBailingualBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalBailingualBatchqueryModel : AopObject
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        [XmlElement("find_text_request")]
        public FindTextRequest FindTextRequest { get; set; }
    }
}
