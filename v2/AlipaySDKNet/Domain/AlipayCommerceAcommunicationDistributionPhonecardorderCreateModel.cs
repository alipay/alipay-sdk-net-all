using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionPhonecardorderCreateModel : AopObject
    {
        /// <summary>
        /// 协议查询返回的流水号
        /// </summary>
        [XmlElement("agreement_request_id")]
        public string AgreementRequestId { get; set; }

        /// <summary>
        /// 办理人姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 办理人身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 渠道参数，无要求可不传
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 办理人联系电话
        /// </summary>
        [XmlElement("contact_phone_number")]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 合作方订单号，用于幂等控制
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单总费用，非支付类可不传
        /// </summary>
        [XmlElement("order_total_fee")]
        public string OrderTotalFee { get; set; }

        /// <summary>
        /// 页面ID，部分商品需要回传
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 号卡归属地省市编码，选号类商品必填
        /// </summary>
        [XmlElement("phone_card_address")]
        public PhoneCardAddressModel PhoneCardAddress { get; set; }

        /// <summary>
        /// 选占的手机号
        /// </summary>
        [XmlElement("phone_num")]
        public string PhoneNum { get; set; }

        /// <summary>
        /// 号卡收货地址
        /// </summary>
        [XmlElement("shipping_address")]
        public PhoneCardShippingAddressModel ShippingAddress { get; set; }
    }
}
