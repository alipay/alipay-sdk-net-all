using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderEcsignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderEcsignApplyModel : AopObject
    {
        /// <summary>
        /// 用于填充合同模板的信息，json格式字符串
        /// </summary>
        [XmlElement("additional_info")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// 业务流水号，发起一次签约申请的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ec_template_codes")]
        [XmlArrayItem("string")]
        public List<string> EcTemplateCodes { get; set; }

        /// <summary>
        /// 支付宝服务器主动通知商户服务器里指定的页面http/https路径
        /// </summary>
        [XmlElement("ecsign_notify_url")]
        public string EcsignNotifyUrl { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("signers")]
        [XmlArrayItem("rent_ec_signer_d_t_o")]
        public List<RentEcSignerDTO> Signers { get; set; }
    }
}
