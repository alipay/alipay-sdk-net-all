using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppAccountBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppAccountBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 机构的子户账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 查询余额的日终日期，20211101代表查询2021年11月1日的日终余额
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 机构本次调用说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
