using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdCamPagination Data Structure.
    /// </summary>
    [Serializable]
    public class AdCamPagination : AopObject
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 单页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据总量。单位：条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
