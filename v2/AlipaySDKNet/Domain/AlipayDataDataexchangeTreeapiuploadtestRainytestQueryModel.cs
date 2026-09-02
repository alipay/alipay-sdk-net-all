using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeTreeapiuploadtestRainytestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeTreeapiuploadtestRainytestQueryModel : AopObject
    {
        /// <summary>
        /// test case
        /// </summary>
        [XmlElement("choose")]
        public string Choose { get; set; }

        /// <summary>
        /// test case
        /// </summary>
        [XmlElement("choose_one_1")]
        public string ChooseOne1 { get; set; }

        /// <summary>
        /// test case
        /// </summary>
        [XmlElement("choose_one_2")]
        public string ChooseOne2 { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlArray("demo")]
        [XmlArrayItem("rainy_public_for_upload_test_complex_info")]
        public List<RainyPublicForUploadTestComplexInfo> Demo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
