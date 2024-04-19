using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalContactDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalContactDeleteModel : AopObject
    {
        /// <summary>
        /// 删除联系人请求
        /// </summary>
        [XmlElement("delete_contact_request")]
        public DeleteContactRequest DeleteContactRequest { get; set; }
    }
}
