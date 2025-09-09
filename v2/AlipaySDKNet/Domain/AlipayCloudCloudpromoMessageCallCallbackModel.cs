using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageCallCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageCallCallbackModel : AopObject
    {
        /// <summary>
        /// 外呼触达明细信息
        /// </summary>
        [XmlElement("action_detail")]
        public CallBackActionDetail ActionDetail { get; set; }

        /// <summary>
        /// 外呼触达结果，用来标识电话呼出状态
        /// </summary>
        [XmlElement("action_result")]
        public long ActionResult { get; set; }

        /// <summary>
        /// 语音外呼时返回的批次号，用于业务执行时的幂等校验
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 该手机号的发送次数，默认1
        /// </summary>
        [XmlElement("call_times")]
        public long CallTimes { get; set; }

        /// <summary>
        /// 用户标识信息,电话外呼时，用手机号做为标识
        /// </summary>
        [XmlElement("customer_key")]
        public string CustomerKey { get; set; }

        /// <summary>
        /// 外部流水号，用于幂等处理,最长64位
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 用户标识类型 MOBILE明文手机号 MOBILE_MD5 MOBILE_SHA256
        /// </summary>
        [XmlElement("param_type")]
        public string ParamType { get; set; }

        /// <summary>
        /// 呼叫结果编码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 外呼结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 语音外呼场景策略由运营来做配置，配置好后策略码由运营提供，用来决策外呼场景
        /// </summary>
        [XmlElement("scene_strategy_id")]
        public string SceneStrategyId { get; set; }
    }
}
