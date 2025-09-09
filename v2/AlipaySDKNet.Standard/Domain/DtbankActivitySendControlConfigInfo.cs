using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtbankActivitySendControlConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtbankActivitySendControlConfigInfo : AopObject
    {
        /// <summary>
        /// API发放限制的APPID列表
        /// </summary>
        [XmlArray("api_send_control_content_list")]
        [XmlArrayItem("string")]
        public List<string> ApiSendControlContentList { get; set; }

        /// <summary>
        /// API发放限制 ACTIVITY_APP_ID：仅活动主体的应用 SPECIFY_APP_ID：指定应用
        /// </summary>
        [XmlElement("api_send_control_type")]
        public string ApiSendControlType { get; set; }

        /// <summary>
        /// 是否参与会场招商 不参与会场招商时返回值为false，参与会场招商时返回参与的会场招商玩法code列表 false:不参与会场招商  RED_PACKET_WITH_FUNDING:红包码【双12配资】RED_PACKET:红包码 2023_BANK_PROMOTION:银行大促 SPRING2023:2023春季大促 AUTUMN_CARDS:金秋消费节COMMERCIAL_MARKETING_VENUE:商户小程序 DOUBLE12_2023:双12主会场 HUNDRED_TIMES_DISCOUNT:百次立减
        /// </summary>
        [XmlArray("play_name_list")]
        [XmlArrayItem("string")]
        public List<string> PlayNameList { get; set; }

        /// <summary>
        /// 是否需要叠加公域流量 true：需要叠加公域流量 false：不叠加公域流量
        /// </summary>
        [XmlElement("public_domain")]
        public bool PublicDomain { get; set; }

        /// <summary>
        /// 发放方式 PAGE:仅支付宝二维码及链接发放 API:仅API发放 PAGE_API:支付宝二维码、链接及API发放
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }
    }
}
