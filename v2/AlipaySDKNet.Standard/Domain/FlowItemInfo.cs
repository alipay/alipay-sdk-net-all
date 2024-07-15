using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FlowItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FlowItemInfo : AopObject
    {
        /// <summary>
        /// 权益列表
        /// </summary>
        [XmlArray("benefit_list")]
        [XmlArrayItem("item_benefit")]
        public List<ItemBenefit> BenefitList { get; set; }

        /// <summary>
        /// 退订说明
        /// </summary>
        [XmlElement("cancel_note")]
        public string CancelNote { get; set; }

        /// <summary>
        /// 商品详情说明
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 流量类型
        /// </summary>
        [XmlElement("flow_type")]
        public string FlowType { get; set; }

        /// <summary>
        /// 常见问题列表
        /// </summary>
        [XmlArray("frequent_qa_list")]
        [XmlArrayItem("item_frequent_q_a")]
        public List<ItemFrequentQA> FrequentQaList { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 产品介绍
        /// </summary>
        [XmlArray("introduction_list")]
        [XmlArrayItem("item_introduction")]
        public List<ItemIntroduction> IntroductionList { get; set; }

        /// <summary>
        /// 运营商
        /// </summary>
        [XmlElement("isp")]
        public string Isp { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否需要用户同意协议
        /// </summary>
        [XmlElement("need_protocol")]
        public bool NeedProtocol { get; set; }

        /// <summary>
        /// 是否可跨月
        /// </summary>
        [XmlElement("over_month")]
        public string OverMonth { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 是否自动续期
        /// </summary>
        [XmlElement("persist")]
        public string Persist { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 价格说明
        /// </summary>
        [XmlElement("price_note")]
        public string PriceNote { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 生效范围
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 验证码长度
        /// </summary>
        [XmlElement("sms_code_length")]
        public long SmsCodeLength { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 订购限制
        /// </summary>
        [XmlElement("subscribe_limit")]
        public string SubscribeLimit { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
