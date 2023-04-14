using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarbonTrans Data Structure.
    /// </summary>
    [Serializable]
    public class CarbonTrans : AopObject
    {
        /// <summary>
        /// 当前查询出来的碳账户总能量值（日，月）
        /// </summary>
        [XmlElement("carbon_value")]
        public string CarbonValue { get; set; }

        /// <summary>
        /// 查询出来的账单数据明细
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("carbon_tran_detail")]
        public List<CarbonTranDetail> DetailList { get; set; }

        /// <summary>
        /// 业务日期（日，月）
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
