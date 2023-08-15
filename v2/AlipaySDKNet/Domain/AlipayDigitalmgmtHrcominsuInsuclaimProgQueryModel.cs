using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimProgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcominsuInsuclaimProgQueryModel : AopObject
    {
        /// <summary>
        /// data_key+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// is_submit+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("is_submit")]
        public long IsSubmit { get; set; }
    }
}
