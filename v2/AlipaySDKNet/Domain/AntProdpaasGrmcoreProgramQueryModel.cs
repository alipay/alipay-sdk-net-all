using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasGrmcoreProgramQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasGrmcoreProgramQueryModel : AopObject
    {
        /// <summary>
        /// 环境标志，必须上送"prod"
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 项目编号
        /// </summary>
        [XmlElement("program_code")]
        public string ProgramCode { get; set; }

        /// <summary>
        /// 租户信息，必须送"ANTGROUP"
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
