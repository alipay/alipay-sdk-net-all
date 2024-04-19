using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationOrderapplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationOrderapplyCreateModel : AopObject
    {
        /// <summary>
        /// 业务字段
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 赔付政策类型
        /// </summary>
        [XmlArray("claim_strategy_list")]
        [XmlArrayItem("claim_strategy")]
        public List<ClaimStrategy> ClaimStrategyList { get; set; }

        /// <summary>
        /// havana_id
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_info")]
        public InsOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 外部业务号(幂等单号)
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品号
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
