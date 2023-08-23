using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestparameterQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestparameterQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_appidoutone")]
        public string ResultAppidoutone { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_appidouttwo")]
        public string ResultAppidouttwo { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_oneuid")]
        public string ResultOneuid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_oneuid_openid")]
        public string ResultOneuidOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_oneuid_oriiginal")]
        public string ResultOneuidOriiginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_oneuid_oriiginal_openid")]
        public string ResultOneuidOriiginalOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test_original")]
        public string ResultTestOriginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test_original_openid")]
        public string ResultTestOriginalOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test_original_states")]
        public string ResultTestOriginalStates { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test_original_states_openid")]
        public string ResultTestOriginalStatesOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test_original_states_test")]
        public OpenidComplex ResultTestOriginalStatesTest { get; set; }

        /// <summary>
        /// result_twouid
        /// </summary>
        [XmlElement("result_twouid")]
        public string ResultTwouid { get; set; }

        /// <summary>
        /// result_twouid
        /// </summary>
        [XmlElement("result_twouid_openid")]
        public string ResultTwouidOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_twouid_oriiginal")]
        public string ResultTwouidOriiginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_twouid_oriiginal_openid")]
        public string ResultTwouidOriiginalOpenid { get; set; }
    }
}
