using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvTaskQueryModel : AopObject
    {
        /// <summary>
        /// 资金管控任务产品码，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("fund_supv_product_code")]
        public string FundSupvProductCode { get; set; }

        /// <summary>
        /// 被管控方证件号码，按实际场景获取
        /// </summary>
        [XmlElement("supervised_id_number")]
        public string SupervisedIdNumber { get; set; }

        /// <summary>
        /// 管控方证件号码
        /// </summary>
        [XmlElement("supervisor_id_number")]
        public string SupervisorIdNumber { get; set; }
    }
}
