using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderAftersaleConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderAftersaleConfirmModel : AopObject
    {
        /// <summary>
        /// 补充描述
        /// </summary>
        [XmlElement("additional_description")]
        public string AdditionalDescription { get; set; }

        /// <summary>
        /// 补充材料
        /// </summary>
        [XmlArray("additional_media_list")]
        [XmlArrayItem("aftersale_media_info_v_o")]
        public List<AftersaleMediaInfoVO> AdditionalMediaList { get; set; }

        /// <summary>
        /// 售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝openid
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 赔付支付参数信息
        /// </summary>
        [XmlElement("compensation_info")]
        public AftersaleCompensationInfoVO CompensationInfo { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 商户售后单号，要保证唯一性
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 支付金额，单位：元，精确到小数点后两位。 注意事项
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单费用项明细列表
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("aftersale_pay_item_v_o")]
        public List<AftersalePayItemVO> PayItems { get; set; }

        /// <summary>
        /// 操作原因类型
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }
    }
}
