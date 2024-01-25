using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdRaasMeterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdRaasMeterQueryModel : AopObject
    {
        /// <summary>
        /// 业务的类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// odps中的dt分区
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 分页的pageNo的值
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 页码的值大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
