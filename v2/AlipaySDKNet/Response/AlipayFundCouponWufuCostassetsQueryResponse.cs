using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCostassetsQueryResponse.
    /// </summary>
    public class AlipayFundCouponWufuCostassetsQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前是否可消耗福卡
        /// </summary>
        [XmlElement("can_cost")]
        public bool CanCost { get; set; }

        /// <summary>
        /// 用户持有的福卡数量列表
        /// </summary>
        [XmlArray("card_numbers")]
        [XmlArrayItem("card_number_v_o")]
        public List<CardNumberVO> CardNumbers { get; set; }

        /// <summary>
        /// 用户当前持有的福卡数量是否满足兑换条件
        /// </summary>
        [XmlElement("have_enough_cards")]
        public bool HaveEnoughCards { get; set; }

        /// <summary>
        /// 福卡不足时的跳转链接
        /// </summary>
        [XmlElement("not_enough_jump_url")]
        public string NotEnoughJumpUrl { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 错误结果显示
        /// </summary>
        [XmlElement("result_view")]
        public string ResultView { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
