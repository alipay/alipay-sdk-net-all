using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuClaimAttachmentVo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuClaimAttachmentVo : AopObject
    {
        /// <summary>
        /// anamnesis+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("anamnesis")]
        [XmlArrayItem("string")]
        public List<string> Anamnesis { get; set; }

        /// <summary>
        /// ids+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// invoice+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("invoice")]
        [XmlArrayItem("string")]
        public List<string> Invoice { get; set; }
    }
}
