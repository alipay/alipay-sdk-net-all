using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftOwnassetUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftOwnassetUserQueryModel : AopObject
    {
        /// <summary>
        /// 博域用户的 id
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小每次最大为30
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
