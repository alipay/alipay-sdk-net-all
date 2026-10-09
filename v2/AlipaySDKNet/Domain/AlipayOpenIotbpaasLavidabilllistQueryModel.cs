using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilllistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasLavidabilllistQueryModel : AopObject
    {
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，最大不超过20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询日期
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }
    }
}
