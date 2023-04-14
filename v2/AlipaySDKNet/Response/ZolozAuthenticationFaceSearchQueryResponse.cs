using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozAuthenticationFaceSearchQueryResponse.
    /// </summary>
    public class ZolozAuthenticationFaceSearchQueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索到的人脸候选集
        /// </summary>
        [XmlArray("candidate_list")]
        [XmlArrayItem("face_search_result")]
        public List<FaceSearchResult> CandidateList { get; set; }

        /// <summary>
        /// 人脸搜索找到的用户
        /// </summary>
        [XmlElement("found_face")]
        public FaceSearchResult FoundFace { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [XmlElement("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [XmlElement("ret_message_sub")]
        public string RetMessageSub { get; set; }
    }
}
