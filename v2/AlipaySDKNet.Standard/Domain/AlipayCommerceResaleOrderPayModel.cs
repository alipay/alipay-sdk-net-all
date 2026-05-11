using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderPayModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部支付流水，需要保证订单下全局唯一。 若重复会幂等返回前序已经发起的一笔流水
        /// </summary>
        [XmlElement("out_pay_id")]
        public string OutPayId { get; set; }

        /// <summary>
        /// 赔付类、订单部分支付类需要
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// FULL_PAY,全额支付 PARTIAL_PAY,部分支付
        /// </summary>
        [XmlElement("pay_amount_type")]
        public string PayAmountType { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        [XmlElement("pay_memo")]
        public string PayMemo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pay_scene_items")]
        [XmlArrayItem("resale_pay_info_v_o")]
        public List<ResalePayInfoVO> PaySceneItems { get; set; }

        /// <summary>
        /// JSAPI（小程序支付）、PAY_AFTER_USE（先享后付）、installmentPay（分期支付）
        /// </summary>
        [XmlElement("pay_tool")]
        public string PayTool { get; set; }

        /// <summary>
        /// ORDER（订单支付）、OTHER（其他支付）
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
