using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossAntlescenterPartcontractFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossAntlescenterPartcontractFinishModel : AopObject
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 上传的合同文件
        /// </summary>
        [XmlElement("file_info")]
        public AntlescenterFileDTO FileInfo { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
