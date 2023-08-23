using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockOpenidtestingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockOpenidtestingQueryModel : AopObject
    {
        /// <summary>
        /// 详细地址 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("appid_one")]
        public string AppidOne { get; set; }

        /// <summary>
        /// appid_out_one 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("appid_out_one")]
        public string AppidOutOne { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("appid_out_three")]
        public string AppidOutThree { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("appid_out_two")]
        public string AppidOutTwo { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("appid_three")]
        public string AppidThree { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("appid_two")]
        public string AppidTwo { get; set; }

        /// <summary>
        /// adadsad
        /// </summary>
        [XmlElement("extra_json")]
        public string ExtraJson { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("extra_json_1")]
        public string ExtraJson1 { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("lalala_openid")]
        public string LalalaOpenid { get; set; }

        /// <summary>
        /// 营业执照有效期
        /// </summary>
        [XmlElement("lalala_real_open_id")]
        public string LalalaRealOpenId { get; set; }

        /// <summary>
        /// 营业执照有效期
        /// </summary>
        [XmlElement("lalalala")]
        public string Lalalala { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("one_open_id")]
        public string OneOpenId { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("one_uid")]
        public string OneUid { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(lalalalalalala)
        /// </summary>
        [XmlElement("result_oneuid_original")]
        public string ResultOneuidOriginal { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("test")]
        public OpenidComplex Test { get; set; }

        /// <summary>
        /// 测试循环嵌套含有json数组和对象
        /// </summary>
        [XmlElement("test_json")]
        public string TestJson { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_wrong")]
        public string TestWrong { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("three_open_id")]
        public string ThreeOpenId { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("three_uid")]
        public string ThreeUid { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("two_open_id")]
        public string TwoOpenId { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlElement("two_uid")]
        public string TwoUid { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此原来如此)
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(原来如此原来如此原来如此)
        /// </summary>
        [XmlArray("uid_list_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> UidListOpenIdList { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("user_detail")]
        public UserDetail UserDetail { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
