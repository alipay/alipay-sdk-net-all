using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenQueryResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFtokenQueryResponse : AopResponse
    {
        /// <summary>
        /// 年龄是否在指定范围内，未指定范围则返回空，true/false
        /// </summary>
        [XmlElement("age_check_result")]
        public string AgeCheckResult { get; set; }

        /// <summary>
        /// 图片base64 encodeString
        /// </summary>
        [XmlElement("authimg_base_64")]
        public string AuthimgBase64 { get; set; }

        /// <summary>
        /// 由ISV定义的对自然人唯一编码，举例可以是身份证号码和姓名的MD5值，或者是其他编码方式，要求脱敏、随机且在ISV可以唯一说明一个自然人
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户名信息返回的列表
        /// </summary>
        [XmlArray("uid_tel_pair_list")]
        [XmlArrayItem("zhub_uid_tel_pair")]
        public List<ZhubUidTelPair> UidTelPairList { get; set; }
    }
}
