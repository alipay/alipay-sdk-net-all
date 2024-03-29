using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMappedidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinCustomerMappedidQueryModel : AopObject
    {
        /// <summary>
        /// DCHAIN("DCHAIN","供应链信用流转平台"), ABS("ABS","ABS资产流转平台"), BAMBOO("BAMBOO","BAMBOO项目"), LOGISTICS_FIN("LOGISTICS_FIN", "物流金融"), TRUSPLE("TRUSPLE", "跨境贸易金融平台");
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// ALIID("ALI_ID","AliID"), ICBU_ACCT_ID("ICBU_ACCT_ID","ICBU_ACCT_ID"), HAVANAL("HAVANAL_ID","HavanaID"), DID("DID","DID"), LEI_ID("LEI_ID","LEI_ID"), OCID("ONE_COMPANY_ID", "ONE_COMPANY_ID"), IP_ID("IP_ID", "网商银行会员IP_ID"), IP_ROLE_ID("IP_ROLE_ID", "网商银行会员IP_ROLE_ID"),
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// ID的值
        /// </summary>
        [XmlElement("id_value")]
        public string IdValue { get; set; }
    }
}
