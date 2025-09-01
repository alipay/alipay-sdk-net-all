using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTransactionInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvTransactionInitializeModel : AopObject
    {
        /// <summary>
        /// 该参数用于明确指定货柜 air 是否开启识别。  非air 柜默认开启识别。
        /// </summary>
        [XmlElement("air_identify")]
        public bool AirIdentify { get; set; }

        /// <summary>
        /// 货柜类型，STATIC-静态柜，DYNAMIC-动态重力柜，PURE_DYNAMIC-动态视觉货柜，STATIC_STATE_WEIGHT-静态重力柜
        /// </summary>
        [XmlElement("device_identify_type")]
        public string DeviceIdentifyType { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_infos")]
        [XmlArrayItem("good_info")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 一键开柜链路唯一识别id
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 标识是什么场景下的视觉识别请求，visionPay,putInOrder,queryAll
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 二级商户ID
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 二级商户名称
        /// </summary>
        [XmlElement("sub_merchant_name")]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 售卖设备编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 货柜重力商品配置列表信息
        /// </summary>
        [XmlArray("weight_template")]
        [XmlArrayItem("weight_floor")]
        public List<WeightFloor> WeightTemplate { get; set; }
    }
}
