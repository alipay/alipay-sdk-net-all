using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSchemainputparamsRainyinoutQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSchemainputparamsRainyinoutQueryModel : AopObject
    {
        /// <summary>
        /// 中文描述
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 判断是否是UID或者OPENID
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 字段映射
        /// </summary>
        [XmlElement("accout_ref_id_type_openid")]
        public string AccoutRefIdTypeOpenid { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [XmlElement("boolean_01_n_select_one")]
        public bool Boolean01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("boolean_02_n_select_one")]
        [XmlArrayItem("boolean")]
        public List<bool> Boolean02NSelectOne { get; set; }

        /// <summary>
        /// date
        /// </summary>
        [XmlElement("date_01_n_select_one")]
        public string Date01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_02_n_select_one")]
        [XmlArrayItem("date")]
        public List<string> Date02NSelectOne { get; set; }

        /// <summary>
        /// number
        /// </summary>
        [XmlElement("num_01_n_select_one")]
        public long Num01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("num_02_n_select_one")]
        [XmlArrayItem("number")]
        public List<long> Num02NSelectOne { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// price
        /// </summary>
        [XmlElement("price_01_n_select_one")]
        public string Price01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("price_02_n_select_one")]
        [XmlArrayItem("price")]
        public List<string> Price02NSelectOne { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("string_01_n_select_one")]
        public string String01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("string_02_n_select_one")]
        [XmlArrayItem("string")]
        public List<string> String02NSelectOne { get; set; }

        /// <summary>
        /// 废弃 当前字段已废弃(Rainy新模型测试)
        /// </summary>
        [XmlElement("tc_case")]
        public string TcCase { get; set; }

        /// <summary>
        /// mix uid type
        /// </summary>
        [XmlElement("tc_mix_uid")]
        public string TcMixUid { get; set; }

        /// <summary>
        /// mix uid type
        /// </summary>
        [XmlElement("tc_mix_uid_ref_openid")]
        public string TcMixUidRefOpenid { get; set; }

        /// <summary>
        /// not uid
        /// </summary>
        [XmlElement("tc_not_uid")]
        public string TcNotUid { get; set; }

        /// <summary>
        /// openId json type
        /// </summary>
        [XmlElement("tc_openid_json")]
        public string TcOpenidJson { get; set; }

        /// <summary>
        /// desc中文描述拉
        /// </summary>
        [XmlElement("tc_pid")]
        public string TcPid { get; set; }

        /// <summary>
        /// smid中文描述拉
        /// </summary>
        [XmlElement("tc_smid")]
        public string TcSmid { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id_ref_openid")]
        public string UserIdRefOpenid { get; set; }
    }
}
