using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceVoucherResultConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceVoucherResultConsultModel : AopObject
    {
        /// <summary>
        /// isv的商户pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 咨询商品信息
        /// </summary>
        [XmlElement("item_consult_list")]
        public ItemConsultRequest ItemConsultList { get; set; }

        /// <summary>
        /// 核销门店的pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 订单金额（如同时享受商户自有优惠请先扣除后传入），单位为元，最多2位小数
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
