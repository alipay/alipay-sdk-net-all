using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignTaskRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignTaskRequest : AopObject
    {
        /// <summary>
        /// 待签署文件列表
        /// </summary>
        [XmlArray("ant_sign_file_request_list")]
        [XmlArrayItem("ant_sign_file_request")]
        public List<AntSignFileRequest> AntSignFileRequestList { get; set; }

        /// <summary>
        /// 签署人信息
        /// </summary>
        [XmlArray("ant_sign_user_info_request_list")]
        [XmlArrayItem("ant_sign_user_info_request")]
        public List<AntSignUserInfoRequest> AntSignUserInfoRequestList { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否关联业务，默认：false
        /// </summary>
        [XmlElement("related_business")]
        public bool RelatedBusiness { get; set; }

        /// <summary>
        /// 子业务流水号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }
    }
}
