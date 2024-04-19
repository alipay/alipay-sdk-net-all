using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlawManualfileUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlawManualfileUploadModel : AopObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("contract_file_v_o")]
        public List<ContractFileVO> FileList { get; set; }

        /// <summary>
        /// 鉴权token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
