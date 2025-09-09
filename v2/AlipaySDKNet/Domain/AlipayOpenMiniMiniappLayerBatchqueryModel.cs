using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappLayerBatchqueryModel : AopObject
    {
        /// <summary>
        /// 第一页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据长度为入参值
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
