using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftscvpayTransactionInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftscvpayTransactionInitializeModel : AopObject
    {
        /// <summary>
        /// 货柜类型，static为静态货柜，dynamic为动态货柜
        /// </summary>
        [XmlElement("device_identify_type")]
        public string DeviceIdentifyType { get; set; }

        /// <summary>
        /// 商品信息,列表
        /// </summary>
        [XmlArray("goods_infos")]
        [XmlArrayItem("good_info")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 视觉货柜机型信息
        /// </summary>
        [XmlElement("machine_type")]
        public string MachineType { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

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
        /// 视觉货柜设备总层数
        /// </summary>
        [XmlElement("total_floors")]
        public long TotalFloors { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 货柜类型，1:友宝货柜, 2:产品化货柜
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

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
