using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingConsultModel : AopObject
    {
        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 核销渠道（AGENT=出境游AI，GUI=常规链路，Voyager 内部映射为 AGENT_ONLY/DEFAULT_GUI）
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 咨询请求号
        /// </summary>
        [XmlElement("consult_request_id")]
        public string ConsultRequestId { get; set; }

        /// <summary>
        /// 环境信息，三方透传
        /// </summary>
        [XmlElement("env_info")]
        public VoyagerEnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 扩展信息，json字符串。风控消费字段：supplierName（供应商名称）、passengerCount（申请人数）、countryCode（签证国家）、productType（商品类型）
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("goods_info_list")]
        [XmlArrayItem("voyager_goods_info")]
        public List<VoyagerGoodsInfo> GoodsInfoList { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>
        /// 用户 openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单价格参数（订单原价，门槛基准）
        /// </summary>
        [XmlElement("order_price_param")]
        public OrderPriceParam OrderPriceParam { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voucher_ids")]
        [XmlArrayItem("string")]
        public List<string> VoucherIds { get; set; }
    }
}
