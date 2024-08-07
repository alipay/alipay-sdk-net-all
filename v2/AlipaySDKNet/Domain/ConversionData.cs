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
        /// 广告创意id，来自：<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的__AD_ID__宏参发生用户点击替换后的值
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 转化事件属性信息，用于转化事件类型相关属性规则上传。 可支持上传属性的转化事件类型及属性规则请参考该文档：<a href='https://adpub.alipay.com/adrlark/ivdktpyh511x9r6i'>转化事件类型属性规则</a>
        /// </summary>
        [XmlArray("attribute_list")]
        [XmlArrayItem("conversion_property")]
        public List<ConversionProperty> AttributeList { get; set; }

        /// <summary>
        /// 转化事件属性信息，用于转化事件类型相关属性规则上传。 可支持上传属性的转化事件类型及属性规则请参考该文档：<a href='https://adpub.alipay.com/adrlark/ivdktpyh511x9r6i'>转化事件类型属性规则</a> 当前字段已废弃(attributes命名不符合规范，需改名)
        /// </summary>
        [XmlElement("attributes")]
        public ConversionProperty Attributes { get; set; }

        /// <summary>
        /// 转化流水号：由用户自定义，用于幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 来自：<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的__CALLBACK_EXT_INFO__宏参发生用户点击替换后的值，需url decode后传回。
        /// </summary>
        [XmlElement("callback_ext_info")]
        public string CallbackExtInfo { get; set; }

        /// <summary>
        /// 用于精准归因，来自：<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的__CID__宏参发生用户点击替换后的值。<br> 支持cid上报的转化事件类型请参见：<br> <a href='https://adpub.alipay.com/lark/adrlark/pg4vb1c0g0u6fx7b'>app推广类转化事件类型</a><br> <a href='https://adpub.alipay.com/lark/adrlark/rvzylhryxh37yplt'>通用类转化事件类型</a>
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 转化金额，单位分。 金额类转化事件必传
        /// </summary>
        [XmlElement("conversion_amount")]
        public string ConversionAmount { get; set; }

        /// <summary>
        /// 转化事件id，当source=COMMON_CONVERSION_ID需上传该字段，其他情况无需上传。
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
        /// 广告创意id，来自：<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的__AD_ID__宏参发生用户点击替换后的值
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
        /// 广告单元id，来自：<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的__GROUP_ID__宏参发生用户点击替换后的值
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// XLIGHT - 灯火归因 MERCHANT -商家自主归因 该字段若为空则默认为XLIGHT
        /// </summary>
        [XmlElement("join_channel")]
        public string JoinChannel { get; set; }

        /// <summary>
        /// 广告计划id，来自：<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的__PLAN_ID__宏参发生用户点击替换后的值
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 商户在灯火pb端的id, 可代替principal_tag。
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 商家标志，可代替principal_id。获取方法： <a href='https://adpub.alipay.com/lark/adrlark/sbk3vetg6ki5m4r8'>principal_tag获取sop</a><br>
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 转化归因字段列表。不同转化事件类型回传property_list不同。请参见回传示例：<br> <a href="https://adpub.alipay.com/lark/adrlark/pvbgwf72ea090877">通用类转化事件回传示例</a><br> <a href="https://adpub.alipay.com/lark/adrlark/kgnnk94p0p1mwbgp">APP推广类转化事件回传示例</a><br>
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("conversion_property")]
        public List<ConversionProperty> PropertyList { get; set; }

        /// <summary>
        /// <br> COMMON_TARGET：<a href='https://adpub.alipay.com/lark/adrlark/rvzylhryxh37yplt'>通用类转化事件类型</a>适用<br> CALLBACK：<a href='https://adpub.alipay.com/lark/adrlark/pg4vb1c0g0u6fx7b'>APP推广类转化事件类型</a>适用<br> 不同source的参数回传规则请参考： COMMON_TARGET：<a href='https://adpub.alipay.com/lark/adrlark/dxw7fkkdnhm45spm'>通用转化回传参数说明</a><br> CALLBACK： <a href='https://adpub.alipay.com/lark/adrlark/wxou6agg3z1o6wyn'>APP推广类转化回传参数说明</a>
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
        /// 发生转化用户的唯一标识。 uuid_type不同，uuid传值不同：<br> 1. 若uuid_type=【PID】：uuid为发生转化用户的2088id。若获取不到，可固定一个值后，上传callback_ext_info参数。<br> 2. 若uuid_type=【OAID_MD5】【IDFA_MD5】【IP_UA】【CAID】【MEI】: uuid传的值为<a href='https://adpub.alipay.com/lark/adrlark/qm1v2gtpvcftele4'>监测上报</a>或<a href='https://adpub.alipay.com/lark/adrlark/gw3740rggm4n5gar'>落地页宏替换</a>配置的对应宏参下发的值<br> 其中当uuid_type=IP_UA时：__IP__、__UA__宏参需用"_"拼接上传<br>
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// 支付宝用户在应用维度下的唯一标识
        /// </summary>
        [XmlElement("uuid_open_id")]
        public string UuidOpenId { get; set; }

        /// <summary>
        /// <a href='https://adpub.alipay.com/lark/adrlark/rvzylhryxh37yplt'>通用类转化事件类型：</a><br> uuid_type固定为PID：表示转化用户唯一标识<br> <a href='https://adpub.alipay.com/lark/adrlark/pg4vb1c0g0u6fx7b'>APP推广类转化事件类型：</a><br> OAID_MD5：表示OAID原值MD5加密后的值<br> IDFA_MD5：表示IDFA原值MD5加密后的值<br> IP_UA：表示IP_UA拼接值，以下划线拼接<br> CAID：表示CAID原值<br> IMEI：表示IMEI原值<br>
        /// </summary>
        [XmlElement("uuid_type")]
        public string UuidType { get; set; }
    }
}
