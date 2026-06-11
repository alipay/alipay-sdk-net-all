using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsTokenPickupNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsTokenPickupNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝跳转商户小程序携带的token，商户通过token回查支付宝获取token关联的运单信息
        /// </summary>
        [XmlElement("info_token")]
        public string InfoToken { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// [     {         "name": "明文匹配",         "value": "L1"     },     {         "name": "大数据匹配",         "value": "L2"     },     {         "name": "疑似包裹",         "value": "L3"     },     {         "name": "疑似包裹",         "value": "L4"     } ]
        /// </summary>
        [XmlElement("match_type")]
        public string MatchType { get; set; }

        /// <summary>
        /// [{"name":"取件码校验","value":"AUTH_CODE_CHECK"},{"name":"基础校验","value":"BASE_CHECK"},{"name":"无校验","value":"ON_CHECK"}]
        /// </summary>
        [XmlElement("pickup_auth_type")]
        public string PickupAuthType { get; set; }

        /// <summary>
        /// token场景 NFC_PICK_PKG碰一下取件
        /// </summary>
        [XmlElement("token_scene")]
        public string TokenScene { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
