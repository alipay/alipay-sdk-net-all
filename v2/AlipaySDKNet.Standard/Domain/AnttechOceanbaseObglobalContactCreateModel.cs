using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalContactCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalContactCreateModel : AopObject
    {
        /// <summary>
        /// 创建联系人请求
        /// </summary>
        [XmlElement("create_contact_request")]
        public CreateContactRequest CreateContactRequest { get; set; }
    }
}
