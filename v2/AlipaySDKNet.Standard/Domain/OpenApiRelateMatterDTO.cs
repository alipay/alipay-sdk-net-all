using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiRelateMatterDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiRelateMatterDTO : AopObject
    {
        /// <summary>
        /// 磋商合同编号
        /// </summary>
        [XmlElement("consult_contract_code")]
        public string ConsultContractCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 事项编码
        /// </summary>
        [XmlElement("matter_code")]
        public string MatterCode { get; set; }

        /// <summary>
        /// 事项名称
        /// </summary>
        [XmlElement("matter_name")]
        public string MatterName { get; set; }

        /// <summary>
        /// 外部合同编号
        /// </summary>
        [XmlElement("out_contract_code")]
        public string OutContractCode { get; set; }
    }
}
