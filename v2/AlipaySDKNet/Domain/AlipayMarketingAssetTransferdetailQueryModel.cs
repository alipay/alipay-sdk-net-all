using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingAssetTransferdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingAssetTransferdetailQueryModel : AopObject
    {
        /// <summary>
        /// 通过场景码控制查询范围
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景参数mapkey：枚举值 （PID）value：参数值
        /// </summary>
        [XmlElement("scene_param_map")]
        public string SceneParamMap { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 默认查询所有交易类型
        /// </summary>
        [XmlArray("trans_types")]
        [XmlArrayItem("string")]
        public List<string> TransTypes { get; set; }
    }
}
