using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QipanMerchantCrowd Data Structure.
    /// </summary>
    [Serializable]
    public class QipanMerchantCrowd : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档 <a href="https://opendocs.alipay.com/pre-open/04phhq" target="_blank">安全应用范围枚举</a>
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 支付宝人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 人群描述
        /// </summary>
        [XmlElement("crowd_desc")]
        public string CrowdDesc { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 由于法务合规要求，仅能展示人群规模的范围。
        /// </summary>
        [XmlElement("crowd_size")]
        public string CrowdSize { get; set; }

        /// <summary>
        /// 商户外部用户人群code 用于标识商家人群，需保证同一商户下crowd_code唯一
        /// </summary>
        [XmlElement("external_crowd_code")]
        public string ExternalCrowdCode { get; set; }

        /// <summary>
        /// 人群是否可见,取值如下： <li>0-人群可见，默认为0</li> <li>1-人群不可见</li>
        /// </summary>
        [XmlElement("hidden")]
        public string Hidden { get; set; }

        /// <summary>
        /// true - 人群支持标签二次加工 false - 人群不支持标签二次加工
        /// </summary>
        [XmlElement("processable")]
        public bool Processable { get; set; }

        /// <summary>
        /// INIT-初始化中 EFFECTIVE-生效 INEFFECTIVE-失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
