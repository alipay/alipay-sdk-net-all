using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalContactModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalContactModifyModel : AopObject
    {
        /// <summary>
        /// 修改联系人请求
        /// </summary>
        [XmlElement("update_contact_request")]
        public UpdateContactRequest UpdateContactRequest { get; set; }
    }
}
