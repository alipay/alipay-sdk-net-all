using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntLinkeAlcollectioncenterCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntLinkeAlcollectioncenterCreateModel : AopObject
    {
        /// <summary>
        /// 欠款信息
        /// </summary>
        [XmlElement("al_collection_create_debt")]
        public AlCollectionCreateDebtDTO AlCollectionCreateDebt { get; set; }

        /// <summary>
        /// 调用方appCode
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 工单信息
        /// </summary>
        [XmlElement("base_info")]
        public AlCollectionReceiveBaseInfoDTO BaseInfo { get; set; }

        /// <summary>
        /// 合同信息
        /// </summary>
        [XmlElement("contract_info")]
        public ContractInfoDTO ContractInfo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 对方信息
        /// </summary>
        [XmlElement("opposite_subject_dto")]
        public OppositeSubjectDTO OppositeSubjectDto { get; set; }

        /// <summary>
        /// 我方主体信息
        /// </summary>
        [XmlElement("our_subject_info")]
        public OurSubjectInfoDTO OurSubjectInfo { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
