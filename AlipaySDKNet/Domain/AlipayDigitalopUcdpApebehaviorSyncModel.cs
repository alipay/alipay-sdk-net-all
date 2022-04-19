using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApebehaviorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApebehaviorSyncModel : AopObject
    {
        /// <summary>
        /// 行为类型：click、expose等
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 渠道：支付宝端、独立客户端等，默认alipay
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 行为对应的itemId列表，如曝光的itemid
        /// </summary>
        [XmlElement("item_id_list")]
        public string ItemIdList { get; set; }

        /// <summary>
        /// 埋点上报时间戳、单位 ms
        /// </summary>
        [XmlElement("log_time")]
        public string LogTime { get; set; }

        /// <summary>
        /// 每个item的展示位置序号position【非必要，最好有】，和item_id_list对应，逗号分割
        /// </summary>
        [XmlElement("pos")]
        public string Pos { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// SPM(Super Position Model)全称超级位置模型，主要用于标识行为发生的位置。SPM位置编码由A/B/C/D四段构成， 各分段分别代表 A:业务， B:页面， C:页面区块， D:区块内点位。段之间用$##$分隔，即A$##$B$##$C$##$D，spm各段建议传明文。允许某一段为空，为空时以_代替。
        /// </summary>
        [XmlElement("spm")]
        public string Spm { get; set; }

        /// <summary>
        /// 推荐请求的traceid，用于关联推荐结果和用户行为
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 用户唯一标识id，支付宝的用户填写支付宝的用户id。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
