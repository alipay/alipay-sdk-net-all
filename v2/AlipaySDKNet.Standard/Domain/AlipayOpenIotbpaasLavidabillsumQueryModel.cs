using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabillsumQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasLavidabillsumQueryModel : AopObject
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }
    }
}
