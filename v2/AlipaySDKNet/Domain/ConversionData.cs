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
        /// 广告id
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 转化事件属性信息，用于转化事件类型相关属性规则上传。 可支持上传属性的转化事件类型及属性规则请参考该文档：<a href='https://adpub.alipay.com/adrlark/ivdktpyh511x9r6i'>转化事件类型属性规则</a>
        /// </summary>
        [XmlElement("attributes")]
        public ConversionProperty Attributes { get; set; }

        /// <summary>
        /// 转化流水号：由用户自定义，用于幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 转化回调扩展信息
        /// </summary>
        [XmlElement("callback_ext_info")]
        public string CallbackExtInfo { get; set; }

        /// <summary>
        /// 来自监测链接配置的__CID__宏参发生用户点击替换的值
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 转化金额，单位分
        /// </summary>
        [XmlElement("conversion_amount")]
        public string ConversionAmount { get; set; }

        /// <summary>
        /// 当source=COMMON_CONVERSION_ID时使用
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化时间，UTC 时间戳，单位：秒
        /// </summary>
        [XmlElement("conversion_time")]
        public long ConversionTime { get; set; }

        /// <summary>
        /// 转化事件类型数字
        /// </summary>
        [XmlElement("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 创意ID
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 当source=XLIGHT或者DATASET时使用：  数据集id 当前字段已废弃(接口升级，该参数已不再使用，故废弃该参数，但不影响历史数据使用。)
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 当source=OTHER时使用:  数据类型： KR_MEMBER - 客如云入会 KR_TRADE - 客如云交易 TB_LIVE -  淘宝直播 当前字段已废弃(接口升级，该参数已不再使用，故废弃该参数，但不影响历史数据使用。)
        /// </summary>
        [XmlElement("data_src_type")]
        public string DataSrcType { get; set; }

        /// <summary>
        /// 单元ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// XLIGHT - 灯火归因 MERCHANT -商家自主归因 该字段若为空则默认为XLIGHT
        /// </summary>
        [XmlElement("join_channel")]
        public string JoinChannel { get; set; }

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
        /// 转化归因字段列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("conversion_property")]
        public List<ConversionProperty> PropertyList { get; set; }

        /// <summary>
        /// 来源： COMMON_TARGET-通用转化事件类型适用 CALLBACK-APP推广类转化事件类型适用 OTHER-其它
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 当source=OTHER时使用： 主体id，例如品牌id 当前字段已废弃(接口升级，该参数已不再使用，故废弃该参数，但不影响历史数据使用。)
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 当source=OTHER时使用：  主体类型： BRAND - 品牌 STORE - 店铺 LIVE - 直播 等等 当前字段已废弃(接口升级，该参数已不再使用，故废弃该参数，但不影响历史数据使用。)
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 转化用户（发生真实转化的用户）唯一标识。 当uuid_type=PID时，传2088UID（例：208801217938xxxx）
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// 支付宝用户在应用维度下的唯一标识
        /// </summary>
        [XmlElement("uuid_open_id")]
        public string UuidOpenId { get; set; }

        /// <summary>
        /// 通用转化事件类型数据回传可使用：PID，表示转化用户唯一标志类型。 自建站转化事件类型可使用：PID_ENCRYPT，自建站转化事件类型编码:445~450。 app推广类转化事件类型可使用： OAID_MD5：oaid md5值 IDFA_MD5：idfa md5值 IP+UA:ip ua拼接值
        /// </summary>
        [XmlElement("uuid_type")]
        public string UuidType { get; set; }
    }
}
