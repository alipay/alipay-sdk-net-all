using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentEcSignApplyInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentEcSignApplyInfoVO : AopObject
    {
        /// <summary>
        /// 申请签署合同的业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 本次申请包含电子合同列表
        /// </summary>
        [XmlArray("contracts")]
        [XmlArrayItem("rent_ec_sign_contract_v_o")]
        public List<RentEcSignContractVO> Contracts { get; set; }

        /// <summary>
        /// 申请受理状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
