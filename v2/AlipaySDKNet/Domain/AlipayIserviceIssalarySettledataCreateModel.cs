using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIssalarySettledataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIssalarySettledataCreateModel : AopObject
    {
        /// <summary>
        /// 结算数据日期入参
        /// </summary>
        [XmlElement("data_date")]
        public string DataDate { get; set; }

        /// <summary>
        /// 回传结算数据详情
        /// </summary>
        [XmlArray("settle_data")]
        [XmlArrayItem("settle_data_detail")]
        public List<SettleDataDetail> SettleData { get; set; }
    }
}
