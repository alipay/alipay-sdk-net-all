using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasGrmcoreSrInvalidModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasGrmcoreSrInvalidModel : AopObject
    {
        /// <summary>
        /// 环境标识，送“prod”
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 项目编号
        /// </summary>
        [XmlElement("program_code")]
        public string ProgramCode { get; set; }

        /// <summary>
        /// sr编号
        /// </summary>
        [XmlArray("sr_nos")]
        [XmlArrayItem("string")]
        public List<string> SrNos { get; set; }

        /// <summary>
        /// 删除供应商code列表
        /// </summary>
        [XmlArray("suppliers")]
        [XmlArrayItem("string")]
        public List<string> Suppliers { get; set; }

        /// <summary>
        /// 租户，必送
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
