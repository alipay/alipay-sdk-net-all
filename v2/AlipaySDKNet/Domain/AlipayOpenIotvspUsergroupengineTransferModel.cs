using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUsergroupengineTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUsergroupengineTransferModel : AopObject
    {
        /// <summary>
        /// 业务流水id,便于问题排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 弹性操作类型
        /// </summary>
        [XmlElement("elastic_type")]
        public string ElasticType { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 签约主体外标id
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 用户刷脸标识集合
        /// </summary>
        [XmlArray("vid_list")]
        [XmlArrayItem("string")]
        public List<string> VidList { get; set; }
    }
}
