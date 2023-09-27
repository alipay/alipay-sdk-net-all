using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingEmployeehomeQueryResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingEmployeehomeQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 零工卡信息
        /// </summary>
        [XmlElement("employee_card_info")]
        public EmployeeCardInfoResDTO EmployeeCardInfo { get; set; }

        /// <summary>
        /// 商户端为以订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 租赁账户信息
        /// </summary>
        [XmlElement("rent_agreement_info")]
        public RentAgreementInfoDTO RentAgreementInfo { get; set; }

        /// <summary>
        /// 接待专户信息
        /// </summary>
        [XmlElement("rent_service_info")]
        public RentServiceInfoDTO RentServiceInfo { get; set; }
    }
}
