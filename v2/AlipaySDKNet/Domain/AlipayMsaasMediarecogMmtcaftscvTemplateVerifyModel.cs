using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel : AopObject
    {
        /// <summary>
        /// 商品Id列表
        /// </summary>
        [XmlArray("algorithm_goods_ids")]
        [XmlArrayItem("string")]
        public List<string> AlgorithmGoodsIds { get; set; }

        /// <summary>
        /// 设备类型，static静态货柜，dynamic为动态货柜
        /// </summary>
        [XmlElement("device_identify_type")]
        public string DeviceIdentifyType { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("good_count")]
        public long GoodCount { get; set; }

        /// <summary>
        /// 机型编号
        /// </summary>
        [XmlElement("machine_type_id")]
        public string MachineTypeId { get; set; }

        /// <summary>
        /// 场景关联id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 商品id冲突校验白名单，逗号分隔字符串对List。例如，一个商品有ABC三个外观，需传入["A,B", "B,C", "A,C"]
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("string")]
        public List<string> WhiteList { get; set; }
    }
}
