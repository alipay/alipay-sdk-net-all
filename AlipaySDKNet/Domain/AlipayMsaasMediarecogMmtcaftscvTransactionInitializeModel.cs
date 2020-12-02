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
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_infos")]
        [XmlArrayItem("good_info")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 一键开柜链路唯一识别id
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 标识是什么场景下的视觉识别请求
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

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
    }
}
