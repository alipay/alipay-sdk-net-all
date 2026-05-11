using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandCorematerialListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandCorematerialListQueryModel : AopObject
    {
        /// <summary>
        /// 页码（默认1）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数（默认10，最大100）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
