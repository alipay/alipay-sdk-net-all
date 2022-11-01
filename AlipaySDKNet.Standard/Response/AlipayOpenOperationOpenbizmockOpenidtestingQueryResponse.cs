using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockOpenidtestingQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockOpenidtestingQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_extra_json")]
        public string ResultExtraJson { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_extra_json_one")]
        public string ResultExtraJsonOne { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("result_extra_json_one_original")]
        public string ResultExtraJsonOneOriginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_extra_json_original")]
        public string ResultExtraJsonOriginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test")]
        public string ResultTest { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("result_test_json")]
        public string ResultTestJson { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("result_test_json_original")]
        public string ResultTestJsonOriginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_test_original")]
        public string ResultTestOriginal { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("result_test_wrong")]
        public string ResultTestWrong { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("result_test_wrong_original")]
        public string ResultTestWrongOriginal { get; set; }

        /// <summary>
        /// 4
        /// </summary>
        [XmlElement("result_user_detail")]
        public UserDetail ResultUserDetail { get; set; }

        /// <summary>
        /// 4
        /// </summary>
        [XmlElement("result_user_detail_original")]
        public string ResultUserDetailOriginal { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_user_id")]
        public string ResultUserId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_user_id_openid")]
        public string ResultUserIdOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result_user_id_original")]
        public string ResultUserIdOriginal { get; set; }
    }
}
