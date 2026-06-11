using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderFundAllVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderFundAllVO : AopObject
    {
        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("order_pay_info")]
        public RecycleOrderPayInfoVO OrderPayInfo { get; set; }

        /// <summary>
        /// 品牌膨胀金信息
        /// </summary>
        [XmlElement("order_subsidy_info")]
        public RecycleStdOrderFundSubSidyVO OrderSubsidyInfo { get; set; }

        /// <summary>
        /// 分账资金信息
        /// </summary>
        [XmlArray("royalty_infos")]
        [XmlArrayItem("recycle_order_royalty_info_v_o")]
        public List<RecycleOrderRoyaltyInfoVO> RoyaltyInfos { get; set; }
    }
}
