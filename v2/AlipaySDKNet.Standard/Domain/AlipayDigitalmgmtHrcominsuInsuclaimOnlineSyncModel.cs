using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimOnlineSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcominsuInsuclaimOnlineSyncModel : AopObject
    {
        /// <summary>
        /// data_key+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// insu_claim_vos+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("insu_claim_vos")]
        [XmlArrayItem("insu_claim_record_vo")]
        public List<InsuClaimRecordVo> InsuClaimVos { get; set; }
    }
}
