using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CfbudmacBizActionConsumedAmountsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CfbudmacBizActionConsumedAmountsDTO : AopObject
    {
        /// <summary>
        /// 业务预算申请占用金额集合
        /// </summary>
        [XmlArray("biz_action_consumed_amount_list")]
        [XmlArrayItem("cfbudmac_biz_action_consumed_amount_d_t_o")]
        public List<CfbudmacBizActionConsumedAmountDTO> BizActionConsumedAmountList { get; set; }

        /// <summary>
        /// 业务活动唯一id
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }
    }
}
