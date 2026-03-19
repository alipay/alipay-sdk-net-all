using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaApplyantsignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthcaApplyantsignCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ant_sign_file_list")]
        [XmlArrayItem("ant_sign_file")]
        public List<AntSignFile> AntSignFileList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ant_sign_user_info_list")]
        [XmlArrayItem("ant_sign_user_info")]
        public List<AntSignUserInfo> AntSignUserInfoList { get; set; }

        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
