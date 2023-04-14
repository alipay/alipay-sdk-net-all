using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConversionData Data Structure.
    /// </summary>
    [Serializable]
    public class ConversionData : AopObject
    {
        /// <summary>
        /// 转化流水号，用于幂等  对于source=XLIGHT，转化流水号来自灯火的留资明细 对于source=DATASET/OTHER，转化流水号由调用方自定义
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 转化回调扩展信息
        /// </summary>
        [XmlElement("callback_ext_info")]
        public string CallbackExtInfo { get; set; }

        /// <summary>
        /// 当source=DATASET或者OTHER时使用：  转化金额，单位分
        /// </summary>
        [XmlElement("conversion_amount")]
        public string ConversionAmount { get; set; }

        /// <summary>
        /// 当source=XLIGHT时使用:  转化事件id，来自推广页关联转化事件id
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化时间，UTC 时间戳，单位：秒
        /// </summary>
        [XmlElement("conversion_time")]
        public long ConversionTime { get; set; }

        /// <summary>
        /// 当source=XLIGHT时使用:  转化事件类型
        /// </summary>
        [XmlElement("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 创意ID
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 当source=XLIGHT或者DATASET时使用：  数据集id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 当source=OTHER时使用:  数据类型： KR_MEMBER - 客如云入会 KR_TRADE - 客如云交易 TB_LIVE -  淘宝直播
        /// </summary>
        [XmlElement("data_src_type")]
        public string DataSrcType { get; set; }

        /// <summary>
        /// 单元ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 商户在灯火pb端的id, 可代替principal_tag
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 商家标志，可代替principal_id
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 当source=DATASET或者OTHER时使用：  转化属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("conversion_property")]
        public List<ConversionProperty> PropertyList { get; set; }

        /// <summary>
        /// 来源： XLIGHT-灯火留资 DATASET-数据集 OTHER-其它
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 当source=OTHER时使用： 主体id，比如品牌id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 当source=OTHER时使用：  主体类型： BRAND - 品牌 STORE - 店铺 LIVE - 直播 等等
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 当source=DATASET或者OTHER时使用：  转化用户唯一标识
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// 当source=DATASET或者OTHER时使用：  转化客户唯一标志类型： PID - 2088pid
        /// </summary>
        [XmlElement("uuid_type")]
        public string UuidType { get; set; }
    }
}
