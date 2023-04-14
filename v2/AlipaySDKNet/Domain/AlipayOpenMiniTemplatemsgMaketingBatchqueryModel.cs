using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTemplatemsgMaketingBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTemplatemsgMaketingBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示条数，最大支持50个
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
