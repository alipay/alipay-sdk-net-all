using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerprivacyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodSerprivacyApplyModel : AopObject
    {
        /// <summary>
        /// 蚂蚁服务申请单号
        /// </summary>
        [XmlElement("apply_order_no")]
        public string ApplyOrderNo { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 请求咨询因子
        /// </summary>
        [XmlArray("consult_factor_list")]
        [XmlArrayItem("service_consult_factor")]
        public List<ServiceConsultFactor> ConsultFactorList { get; set; }

        /// <summary>
        /// 蚂蚁服务合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 请求流水号，每次请求需保持唯一，长度<128
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
